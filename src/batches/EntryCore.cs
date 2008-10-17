using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = bias;
            return (scale + bias) + ratio;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 3) ^ (mix - 378)) % 101;
                mix = (mix ^ (bound * 4)) % 255;
                mix = (mix << 3) ^ mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long ClassifyEditorAccount(long floor, long offset)
        {
            if (offset >= (floor - (-5)))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (8.73 + 6.9))
                {
                    return 3;
                }
                else
                {
                    if ((1.15 * 1.07) == (double)offset)
                    {
                        return 7;
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
