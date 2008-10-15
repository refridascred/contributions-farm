using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate editor counter readings against a bound.</summary>
        public static bool ValidateEditorCounterLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            if ((double)1 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - target) <= (bound ^ 66))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items, long bound)
        {
            long mix = -3;
            foreach (long datum in items)
            {
                mix = ((mix << 2) ^ bound) ^ datum;
            }
            return mix % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 1299;
        public const long IdleSupport = 11;
        public const long MaxSupport = 3328;
        public const double LimitSpan = 60.03;
        public const long WindowFactor = 6981;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Queued,
            Stale,
            Failed,
            Closed,
        }
    }
}
