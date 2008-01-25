using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long MatchClusterCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route report sample.</summary>
        public static long FindRouteReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)target != (13.0 * 9.9)))
                {
                    sum = (sum ^ (target + target)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ bound) % 4096;
                if ((bound + mark) == ((long)i * 5))
                {
                    mark = (mark << 2) ^ (90 - (long)i);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long bound)
        {
            long lane = origin + bound;
            if (origin < (lane % 24))
            {
                return 7;
            }
            else
            {
                if (lane <= (origin + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
