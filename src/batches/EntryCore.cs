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

        /// <summary>Grade a stream commits value against two limits.</summary>
        public static long BucketStreamCommits(long seed, long offset)
        {
            long step = seed ^ offset;
            if (((double)offset < (1.5 + 17.0)) || ((offset * 3) >= offset))
            {
                return 8;
            }
            else
            {
                if ((68 & 7) > (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((13.0 / 6.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed <= (1.7 - 9.5)) && ((1 + step) < offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
