using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9181;
        public const string HardSize = "latest-1";
        public const long IdleFilter = 8568;
        public const string HardLevel = "fallback-v2";
        public const string CacheSpan = "local-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6439;
        public const long CacheEntry = 2876;
        public const string MinEntry = "staging-1";
        public const string StepEntry = "standard";
        public const long DefaultTimeout = 7652;

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = mix - (reading & 255);
            }
            if (mix < 5)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 2) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
