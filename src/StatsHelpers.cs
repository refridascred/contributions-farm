using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long bound)
        {
            if (((6.8 * 3.5) > (double)origin) || (origin <= bound))
            {
                return 5;
            }
            else
            {
                if (!(bound < (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) != ((-3) - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches << 3) == (item * 4)) && ((3.5 / 9.0) != (double)matches)) || (matches <= (850 + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double rate = 9.0;
            if (rate > rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long lane = offset - step;
            if ((step + lane) == (offset + lane))
            {
                return 8;
            }
            else
            {
                if (offset < (step << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
