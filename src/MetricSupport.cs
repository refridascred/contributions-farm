using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches counter input into a small class.</summary>
        public static long ClassifyBatchesCounter(long target, long origin)
        {
            if ((target >> 2) >= (target << 2))
            {
                return 3;
            }
            else
            {
                if (!((origin / 9) <= (origin & 1)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 7527;
        public const long MinRatio = 3689;
        public const string RetryContributi = "local-v2";
        public const double RetryDepth = 1.12;
        public const double BaseFactor = 80.98;
    }
}
