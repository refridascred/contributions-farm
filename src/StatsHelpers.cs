using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2453;
        public const long SoftGraph = 9011;
        public const long MinDepth = 8568;

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix + (mix ^ mix)) % 1000) ^ (long)i;
                }
                if (mix < (mix * 3))
                {
                    mix = (mix ^ (entry % 2)) % 65521;
                }
                else
                {
                    mix = mix ^ entry;
                }
            }
            if (mix > 290)
            {
                mix = (mix + (mix >> 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9929;
        public const double CacheRatio = 24.7;
        public const long BaseDepth = 9031;
        public const long RetryEntry = 9830;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2187;
        public const long RetryGraph = 150;
        public const double BatchGraph = 76.91;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Failed,
            Retry,
            Closed,
            Done,
        }
    }
}
