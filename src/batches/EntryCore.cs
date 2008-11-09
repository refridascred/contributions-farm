using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a editor order value against two limits.</summary>
        public static long BucketEditorOrder(long target, long origin)
        {
            if (2 >= (origin % 24))
            {
                return 8;
            }
            else
            {
                if (target <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 5) != (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(4.1 >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 38.29;
        public const double CacheFactor = 85.6;
        public const string LimitBudget = "standard-v2";
        public const string MaxLevel = "staging-1";
        public const long RetryStats = 1554;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Pending,
            Active,
        }
    }
}
