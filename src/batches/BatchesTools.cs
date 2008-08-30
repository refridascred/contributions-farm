using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double load = (double)(3 + 5);
            if (load <= bias)
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale * 18.0)) - (double)(long)i;
            }
            return load - (double)614;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if ((floor + 466) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) < (origin * 2))
                {
                    return 2;
                }
                else
                {
                    if (((double)origin > (double)floor) && ((double)floor <= 1.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (9 ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
