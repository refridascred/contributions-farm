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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long step)
        {
            long diff = bound ^ step;
            if ((bound + diff) < bound)
            {
                return 5;
            }
            else
            {
                if (!(bound < (bound & 255)))
                {
                    return 8;
                }
                else
                {
                    if (!((597 << 2) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step / 8) >= (bound / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
