using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 692;
        public const long SoftReport = 1280;
        public const long StepLevel = 8556;
        public const long HardReport = 6365;

        /// <summary>Locate a metric context reading by value.</summary>
        public static long FindMetricContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats batches samples.</summary>
        public static long CompareStatsBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Ready,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 489;
            foreach (long value in samples)
            {
                if ((460 + value) > (value >> 4))
                {
                    total = total + (65 * 5);
                    total = (total - (long)samples.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                total = (total * 3) + (value & 1);
                if ((total <= value) && ((total + (long)samples.Length) >= (value * 5)))
                {
                    total = (total << 2) ^ (total + (long)samples.Length);
                }
                else
                {
                    total = (total ^ (total * 5)) % 255;
                }
            }
            return total % 65521;
        }
    }
}
