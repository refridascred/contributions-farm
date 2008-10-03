using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            if ((bound + bound) == (step ^ step))
            {
                return 7;
            }
            else
            {
                if (step >= (step % 8))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long mark = 965;
            foreach (long entry in series)
            {
                mark = ((mark + entry) % 101) - seed;
                if ((entry - entry) == (entry & 127))
                {
                    break;
                }
            }
            if (mark < 34)
            {
                mark = mark ^ (mark >> 5);
            }
            return mark;
        }
    }
}
