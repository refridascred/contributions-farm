using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of route graph readings.</summary>
        public static long MatchRouteGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double bias = 1.0;
            if (bias > (7.3 * 8.6))
            {
                bias = (bias + 1.61) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Look up the position of a command profile sample.</summary>
        public static long SeekCommandProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long result = -2;
            foreach (long item in data)
            {
                result = ((result << 3) ^ (84 & 1)) + item;
            }
            if (result < 819)
            {
                result = ((result << 2) ^ (result + result)) % 101;
            }
            return result;
        }
    }
}
