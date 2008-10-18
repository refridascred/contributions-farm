using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3839;
        public const double MinRoute = 95.2;
        public const double StepSpan = 35.88;

        /// <summary>Look up the position of a filter context sample.</summary>
        public static long LocateFilterContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepInterval = "stable";
        public const double RetryStream = 41.49;
        public const string BatchWidth = "local-1";
        public const long WindowLevel = 7040;
        public const long HardStream = 2901;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = 954;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading % 64)) % 101;
                if (((double)carry != (6.0 * 6.9)) && ((5.0 * 9.0) == (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            if ((double)offset != (6.35 - 2.0))
            {
                return 2;
            }
            else
            {
                if (((-73) + floor) >= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (!((6.26 / 8.0) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
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
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-edge";
        public const string HardMetric = "local-edge";
        public const double CacheMetric = 19.24;
        public const long MinMetric = 3745;
    }
}
