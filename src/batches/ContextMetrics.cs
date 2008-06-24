using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long offset)
        {
            long anchor = 706;
            foreach (long value in values)
            {
                if ((value + offset) > offset)
                {
                    continue;
                }
                if ((value ^ offset) == (value * 2))
                {
                    anchor = ((anchor * 3) + (value + value)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long GradeOrderSession(long origin, long floor)
        {
            long prev = origin + floor;
            if ((0.4 - 3.4) < (double)prev)
            {
                return 5;
            }
            else
            {
                if (prev >= (origin * 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long offset)
        {
            long edge = seed + offset;
            if (!(seed >= (offset % 7)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (1.0 * 5.1))
                {
                    return 4;
                }
                else
                {
                    if ((edge % 100) <= (offset % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        if (edge <= (offset & 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
