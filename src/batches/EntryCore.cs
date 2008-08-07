using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSpan = 65.27;
        public const long HardWidth = 2863;
        public const string SoftAlready = "standard-1";
        public const double MaxTimeout = 14.85;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long limit)
        {
            long cur = bound + limit;
            if (((limit + bound) <= (666 + limit)) && (((-3) - cur) == (cur << 2)))
            {
                return 3;
            }
            else
            {
                if (!((limit + limit) >= (cur - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (2.7 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)(-9)) + (double)(long)i) + weight;
            }
            return rate + (span - span);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (51 <= (floor / 2))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
