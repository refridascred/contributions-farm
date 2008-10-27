using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen == (double)(long)levels.Length))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed >> 3) > 688) || ((seed + seed) == (target >> 3)))
            {
                return 2;
            }
            else
            {
                if ((((-1) + seed) == (174 >> 5)) || ((double)target >= (1.0 * 15.0)))
                {
                    return 4;
                }
                else
                {
                    if ((target - seed) == (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
