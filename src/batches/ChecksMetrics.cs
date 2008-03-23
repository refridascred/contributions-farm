using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseRatio = "stable";
        public const double BaseEditor = 81.72;
        public const long CacheSize = 5069;
        public const long BatchScore = 9809;
        public const double SoftWidth = 51.85;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = (((carry << 2) ^ (seed + carry)) % 255) ^ entry;
            }
            return carry;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry * 3) + (8 + carry)) - (long)i2;
                    carry = (carry - (bound ^ bound)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the stats report series from a seed.</summary>
        public static long IterateStatsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (total < ((long)i >> 2))
                {
                    break;
                }
                total = (total + (bound * 2)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            long diff = floor + floor2;
            if ((diff << 1) >= (floor << 2))
            {
                return 2;
            }
            else
            {
                if (258 >= (diff + 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 / 9) >= (floor2 ^ diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < diff))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
