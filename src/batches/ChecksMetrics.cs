using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long floor)
        {
            if (9.8 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((6.0 - 16.0) == (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count session schema pairs that satisfy a relation.</summary>
        public static long MatchSessionSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((121 + matches) != (origin >> 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (ratio * 5.4))
            {
                bias2 = bias2 - ratio;
            }
            return bias2 - ratio;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long anchor = 4;
            foreach (long cell in values)
            {
                if (anchor > (770 % 5))
                {
                    anchor = (anchor * 5) + cell;
                }
                if ((anchor + anchor) <= (cell * 2))
                {
                    break;
                }
            }
            if (anchor > 25)
            {
                anchor = (anchor ^ (anchor % 64)) % 4096;
            }
            return anchor;
        }
    }
}
