using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double ratio = (5.5 / 7.0) - (0.3 / 2.0);
            if (ratio >= (ratio * 12.0))
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio + (rate * 3.8);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 70;
            foreach (long value in items)
            {
                if ((2.4 - 17.0) <= (double)value)
                {
                    total = (total * 2) + ((-92) * 5);
                }
                else
                {
                    total = ((total * 3) + value) % 65521;
                }
            }
            if (total > 1)
            {
                total = ((total * 5) + (total * 3)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long origin)
        {
            if ((floor - origin) > (floor >> 5))
            {
                return 1;
            }
            else
            {
                if ((floor + origin) <= (origin + floor))
                {
                    return 4;
                }
                else
                {
                    if (origin >= (floor - 21))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 4.0) < (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
