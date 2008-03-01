using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seed + 60) <= (reading & 255))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double bias)
        {
            double bias2 = (double)(-30) - (double)89;
            if (bias2 < (rate * 5.5))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}
