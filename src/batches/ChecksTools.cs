using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a commits order pair into a bucket.</summary>
        public static long SortCommitsOrder(long step, long origin)
        {
            long gap = step ^ origin;
            if (!((step % 97) < step))
            {
                return 7;
            }
            else
            {
                if (step >= (gap << 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxScore = 5847;
        public const long LimitChannel = 1115;
        public const long MaxChannel = 6764;
        public const string LimitLevel = "strict-v2";
    }
}
