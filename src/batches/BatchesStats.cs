using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long floor)
        {
            if ((origin + floor) >= (floor ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 16) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (!((91 - origin) < (floor + origin)))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 25.52;
        public const long MinTimeout = 9869;
        public const double IdleStream = 71.77;
        public const double MinBudget = 11.44;
        public const string IdleTimeout = "primary";

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
