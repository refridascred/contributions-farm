using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if (limit > ((-29) - limit2))
            {
                return 0;
            }
            else
            {
                if ((limit2 >> 3) != (cur << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 - 68) != (limit - limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)cur >= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double weight = floor;
            if (weight < gain)
            {
                weight = weight + (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight - (double)419;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
