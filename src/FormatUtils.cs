using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the metrics command series from a seed.</summary>
        public static long SeriesMetricsCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = sum - (offset - offset);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double mean = (bias * 7.73) - bias;
            if (mean > (floor - 4.5))
            {
                mean = mean - (double)3;
            }
            return mean - 2.88;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank filter session input into a small class.</summary>
        public static long SortFilterSession(long limit, long seed)
        {
            if ((double)seed != (3.0 + 2.0))
            {
                return 1;
            }
            else
            {
                if (seed >= (limit - seed))
                {
                    return 4;
                }
                else
                {
                    if ((3 + seed) > (51 - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Retry,
            Dropped,
            Locked,
        }
    }
}
