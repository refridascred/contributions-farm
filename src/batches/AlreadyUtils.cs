using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double scale = 9.6;
            if (scale > scale)
            {
                scale = (scale + bias) + bias2;
            }
            else
            {
                scale = scale - 12.0;
            }
            return scale - scale;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a contributi account pair into a bucket.</summary>
        public static long ClassifyContributiAccount(long origin, long limit)
        {
            if (((73 * 4) == (limit << 3)) || ((double)origin <= (1.0 + 9.4)))
            {
                return 6;
            }
            else
            {
                if (!((limit & 1) == (origin >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 5) != (17 ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit - origin) < limit) && ((origin % 8) < origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
