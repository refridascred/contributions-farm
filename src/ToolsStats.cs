using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long SeriesContributiRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ ((long)i / 9)) % 97;
                sum = (sum << 3) ^ (bound * 4);
                sum = ((sum * 5) + 212) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((6.64 - 8.9) != (double)tally) || !((tally >> 1) < 117))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((target ^ matches) != (target >> 5))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double rate = scale + floor;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (7.41 - rate)) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
