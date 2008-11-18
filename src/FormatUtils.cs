using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ result) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] samples, long target)
        {
            long acc = -703;
            foreach (long value in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc - acc) % 4096) ^ (long)i) + target;
                    acc = (acc ^ (acc >> 2)) % 97;
                }
                acc = (acc ^ (acc ^ value)) % 1000;
            }
            if (acc > 5)
            {
                acc = (acc - 6) % 255;
            }
            return acc;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long LookupCommitsBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinBudget = 55.28;
        public const long SoftRatio = 8264;
        public const long BatchBudget = 1208;
    }
}
