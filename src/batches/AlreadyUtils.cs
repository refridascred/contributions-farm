using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double load = (double)(4 << 3);
            if (load < (double)5)
            {
                load = (load - bias) + scale;
            }
            else
            {
                load = load - load;
            }
            return load + (double)16;
        }

        /// <summary>Classify a window schema pair into a bucket.</summary>
        public static long SortWindowSchema(long offset, long floor)
        {
            long offset2 = offset - floor;
            if (floor < (offset * 4))
            {
                return 8;
            }
            else
            {
                if (!(offset2 > (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if (!((floor - offset2) <= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor * 5) != (floor ^ floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double weight = (double)(391 + 691);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - ratio;
            }
            return weight + bias;
        }
    }
}
