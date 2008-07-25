using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long floor)
        {
            if ((bound < (floor & 31)) || ((double)floor != (3.89 / 2.0)))
            {
                return 7;
            }
            else
            {
                if (((floor + floor) != (bound - bound)) || ((4.21 * 6.13) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (79 > (floor + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a batch filter figure with a bias.</summary>
        public static double SmoothBatchFilter(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= (rate + rate))
            {
                ratio = ratio - floor;
            }
            return ratio + (rate / 9.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Queued,
            Pending,
            Done,
            Draft,
        }
    }
}
