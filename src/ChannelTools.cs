using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long seed)
        {
            if (seed <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) < (47 ^ seed))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 4) < (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 5) >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double mean = 7.7;
            return (mean + (floor / 2.0)) + ratio;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values)
        {
            long total = 917;
            foreach (long cell in values)
            {
                if (total < (total & 15))
                {
                    total = (total ^ (total + cell)) % 4096;
                    total = ((total << 3) ^ (49 + total)) % 101;
                }
                if ((cell % 8) >= cell)
                {
                    total = (total + (5 >> 2)) % 97;
                }
            }
            return total;
        }
    }
}
