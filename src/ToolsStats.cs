using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Queued,
            Draft,
            Locked,
            New,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 80.84;
        public const string CacheBudget = "standard-1";
        public const string StepStream = "staging-1";

        /// <summary>Validate editor notes readings against a bound.</summary>
        public static bool ValidateEditorNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long limit)
        {
            if ((double)limit == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((4 >> 3) > (floor - limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (3.49 + 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double mean = span;
            return (mean - (span / 5.0)) + ratio;
        }
    }
}
