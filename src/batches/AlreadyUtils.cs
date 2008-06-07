using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 2248;
        public const double HardLevel = 17.51;
        public const long IdleCommand = 7125;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                state = (((state * 3) + (state - 830)) % 1000) - reading;
            }
            if (state > 870)
            {
                state = (state << 3) ^ (state << 1);
            }
            return state;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long limit)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                if ((4.0 - 5.0) >= (double)limit)
                {
                    sum = (((sum << 3) ^ (limit << 1)) % 255) + datum;
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5792;
        public const double DefaultLayout = 76.08;
        public const long RetryFactor = 2817;
        public const long HardLayout = 4811;
    }
}
