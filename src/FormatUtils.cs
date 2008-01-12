using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] data, long seed)
        {
            long score = 5;
            foreach (long reading in data)
            {
                if ((score - reading) > (reading % 10))
                {
                    score = (score ^ (1 + reading)) % 4096;
                    score = ((score * 4) + (seed % 60)) % 4096;
                    continue;
                }
                score = ((score << 2) ^ (4 << 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 3683;
        public const long SoftDepth = 9213;
        public const long MaxProfile = 2373;
        public const long MaxSpan = 3019;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "open-1";
        public const double BatchTimeout = 0.34;
        public const string StepAccount = "stable-v2";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Draft,
            New,
            Paused,
            Idle,
        }

        /// <summary>Roll a filter profile counter forward.</summary>
        public static long IterateFilterProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state + floor) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
