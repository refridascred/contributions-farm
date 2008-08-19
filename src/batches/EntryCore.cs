using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate context cache samples.</summary>
        public static long FoldContextCache(long[] values, long bound)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                if ((mix + cell) >= (7 + mix))
                {
                    mix = (mix ^ bound) % 101;
                    mix = ((mix * 2) + (76 >> 3)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (bound >> 2)) % 1000;
                    mix = ((mix * 5) + (mix * 4)) % 255;
                }
                if (((bound / 2) != (bound - mix)) && ((443 + cell) >= (233 - mix)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 5741;
        public const long MaxBatch = 3231;
        public const long RetryBatch = 113;
        public const long IdleBudget = 1221;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}
