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

        /// <summary>Count editor commits pairs that satisfy a relation.</summary>
        public static long PairEditorCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
