using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double drift = (double)6;
            if (drift <= (bias / 3.0))
            {
                drift = drift + (drift * 6.0);
            }
            return drift + ratio;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double bias = (double)(6 << 1);
            return (bias - floor) + ratio;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.3 + 19.0)))
            {
                return 5;
            }
            else
            {
                if ((diff % 12) >= (3 >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((3 << 2) <= (origin % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit != (double)origin)
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
