using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long bound, long seed)
        {
            long edge = bound - seed;
            if ((0.1 + 7.5) < (double)edge)
            {
                return 6;
            }
            else
            {
                if ((double)edge <= (1.89 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) <= (4 / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 5) >= (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 8682;
        public const string WindowDepth = "stable-1";
        public const string SoftSession = "primary";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long floor)
        {
            if ((floor % 24) > floor)
            {
                return 6;
            }
            else
            {
                if (((1 + bound) < floor) && ((bound << 3) > bound))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
