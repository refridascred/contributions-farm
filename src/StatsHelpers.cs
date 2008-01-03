using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long offset)
        {
            long slot = step + offset;
            if (((offset >> 4) > (slot << 1)) || (offset <= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 0.7)
                {
                    return 4;
                }
                else
                {
                    if ((slot + slot) > 40)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 82.67;
        public const double MinSize = 70.74;
        public const long SoftBudget = 9610;
        public const long RetryQueue = 4359;
        public const string MaxQueue = "open-edge";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long offset)
        {
            long diff = seed + offset;
            if ((seed / 8) <= (offset << 2))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) == (18 + offset)) || ((diff >> 2) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ (-45)) != (seed + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (mark ^ origin);
                mark = mark - (43 & 63);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
