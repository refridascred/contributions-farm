using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double drift = bias / 8.0;
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)391;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((15.0 - 16.0) >= (double)entry)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long floor)
        {
            if (((origin << 1) >= floor) || (origin >= floor))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) != (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) < (floor >> 2)) || ((origin - floor) > (floor - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
