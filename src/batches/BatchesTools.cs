using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
