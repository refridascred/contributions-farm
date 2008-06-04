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

        /// <summary>Grade a command token value against two limits.</summary>
        public static long RankCommandToken(long bound, long floor)
        {
            if (floor < (4 / 8))
            {
                return 2;
            }
            else
            {
                if (((bound ^ bound) >= floor) || ((floor ^ floor) <= (bound + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ bound) >= (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double load = weight;
            return (load + 6.14) + floor;
        }
    }
}
