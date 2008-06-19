using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a counter stream value against two limits.</summary>
        public static long RankCounterStream(long offset, long bound)
        {
            if ((offset - offset) >= offset)
            {
                return 8;
            }
            else
            {
                if (((1.1 * 1.58) >= (double)bound) || (offset < 886))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            New,
            Queued,
            Ready,
        }
    }
}
