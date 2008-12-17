using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a farm metrics reading.</summary>
        public static double SmoothFarmMetrics(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (double)616) + (double)(long)i) + floor;
            }
            return load + (scale * 3.9);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            if (!((limit2 ^ limit) == (limit * 5)))
            {
                return 1;
            }
            else
            {
                if ((limit > (limit - limit2)) || ((double)limit != (16.0 + 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.1 + 5.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 ^ limit2) >= (limit / 2))
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

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
