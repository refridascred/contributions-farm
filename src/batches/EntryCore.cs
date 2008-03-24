using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = scale + span;
            }
            return scale - (span * 4.7);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinScore = 9998;
        public const long DefaultInterval = 5002;
        public const double IdleSupport = 41.41;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long floor)
        {
            long offset = seed ^ floor;
            if ((double)floor != (8.55 / 2.0))
            {
                return 1;
            }
            else
            {
                if (((floor ^ offset) == (floor - 31)) && ((offset ^ seed) >= (seed * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!((9 / 8) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
