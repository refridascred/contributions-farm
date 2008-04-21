using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)seed < (2.3 - 2.53)) || ((value ^ seed) == ((long)levels.Length * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if ((floor * 5) > 8)
            {
                return 1;
            }
            else
            {
                if (!(target >= floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Project the next cache token value.</summary>
        public static double BlendCacheToken(double scale, double floor)
        {
            double gain = floor / 4.0;
            if (gain > floor)
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain - (double)814;
            }
            return gain + (double)(-47);
        }
    }
}
