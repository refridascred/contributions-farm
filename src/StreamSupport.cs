using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 9153;
        public const long StepCommits = 6782;
        public const long MaxCommits = 5740;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((total + seed) != ((long)i / 4)))
                {
                    total = ((total * 4) + (seed << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
