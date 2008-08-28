using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
        public static long CountMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches < (matches ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((-92) < (value >> 4)) && ((value * 3) < (value ^ value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
