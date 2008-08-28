using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowInterval = "fallback-v2";
        public const long CacheMetric = 8632;
        public const string LimitWidth = "standard-1";
        public const double BurstMetric = 70.31;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry + (floor & 3)) % 4096) + (long)i;
                }
                if ((double)floor != (double)value)
                {
                    break;
                }
                if (((carry / 8) > 230) || ((16.0 + 3.3) > (double)carry))
                {
                    carry = (carry << 2) ^ (value + 27);
                }
                else
                {
                    carry = carry ^ (carry % 16);
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1896;
        public const long RetryNotes = 7172;
        public const long MaxNotes = 3149;
        public const string BatchSize = "staging";
        public const double CacheWidth = 94.38;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((79 - (long)items.Length) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double ratio2 = 5.6;
            if (ratio2 > (double)2)
            {
                ratio2 = (ratio2 - (ratio2 + ratio)) - span;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + ratio2;
        }
    }
}
