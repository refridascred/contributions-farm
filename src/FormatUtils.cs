using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)floor <= 2.91)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double mean = 14.0;
            if (mean > mean)
            {
                mean = (mean + floor) + ratio;
            }
            return mean - (double)12;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long step)
        {
            if (((-441) / 5) == (target & 63))
            {
                return 7;
            }
            else
            {
                if (0 >= step)
                {
                    return 1;
                }
                else
                {
                    if ((target <= 321) && ((target - target) != (26 >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)lane == (double)82)
            {
                return 7;
            }
            else
            {
                if (lane >= 445)
                {
                    return 8;
                }
                else
                {
                    if ((771 * 3) >= (8 ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed >= (floor % 12)))
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
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 9883;
        public const double IdleBatches = 73.5;
        public const long BurstTimeout = 9997;
    }
}
