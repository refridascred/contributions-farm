using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2601;
        public const string BatchInterval = "cached-1";
        public const long BatchProfile = 4596;
        public const long MaxSize = 7374;
        public const long HardProfile = 901;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (total & 7)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((1.0 + 8.07) != (double)origin)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
