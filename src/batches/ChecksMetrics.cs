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

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long anchor = 482;
            foreach (long reading in samples)
            {
                anchor = (anchor * 2) + (reading % 10);
                if ((double)reading > (7.8 / 4.0))
                {
                    anchor = (anchor * 3) + (anchor % 2);
                }
            }
            return anchor;
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

        /// <summary>Project the next stream command value.</summary>
        public static double ProjectStreamCommand(double gain, double offset)
        {
            double rate = (double)(-67) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 15.0) + (double)(long)i) - offset;
            }
            return rate + (gain - 2.7);
        }
    }
}
