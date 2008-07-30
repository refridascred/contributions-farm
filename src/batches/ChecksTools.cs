using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i % 5) <= (65 >> 3)) || (((long)i + (-2)) <= (total - target)))
                {
                    total = (total - target) % 255;
                }
                else
                {
                    total = (total + (target + 5)) % 1000;
                }
                total = ((total * 4) + (total ^ 991)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long origin)
        {
            long mark = 899;
            foreach (long cell in values)
            {
                if ((double)origin < 2.0)
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long target)
        {
            long bound = floor + target;
            if ((double)287 != (double)target)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) < (floor - target))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound < (double)floor) && (9.0 >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target + bound) > (67 % 64)) && ((floor + (-703)) != (floor % 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
