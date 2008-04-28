using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((double)limit != (8.3 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((6.4 - 6.32) > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double SmoothWindowGraph(double ratio, double bias)
        {
            double scale = (bias + 4.5) - ratio;
            return scale - 10.0;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 16) >= (hits >> 3))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series)
        {
            long mix = 909;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (mix >> 4)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
