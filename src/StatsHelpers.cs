using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a account record reading.</summary>
        public static double BlendAccountRecord(double rate, double bias)
        {
            double gain = bias;
            return (gain - bias) + rate;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token filter value against two limits.</summary>
        public static long BucketTokenFilter(long limit, long step)
        {
            if ((1 % 8) <= (limit / 2))
            {
                return 4;
            }
            else
            {
                if ((0.4 + 5.8) != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((89 & 255) <= (limit ^ step)) && (limit <= (step - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.32 + 0.6) < (double)limit) || ((limit + limit) == (limit * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long step)
        {
            long slot = floor ^ step;
            if ((11.0 / 5.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((floor + slot) < ((-3) / 9))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
