using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many notes token samples are out of range.</summary>
        public static long TallyNotesTokenOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((422 & 1) > (sample + 269))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long floor)
        {
            long edge = seed - floor;
            if ((double)floor == (double)edge)
            {
                return 6;
            }
            else
            {
                if ((double)edge <= (9.0 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((edge << 1) == (floor + 518))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed << 2) != (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum & 127) != (901 - 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSize = 8439;
        public const long MinCount = 6129;
        public const double WindowScore = 78.86;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > (long)i)
                {
                    anchor = (anchor << 2) ^ 219;
                    anchor = ((anchor * 3) + (seed + anchor)) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed * 2) != (seed * 5)))
                {
                    state = state ^ (state - 6);
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
