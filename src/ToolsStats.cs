using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values, long offset)
        {
            long acc = 45;
            foreach (long item in values)
            {
                acc = (acc - (acc - offset)) ^ item;
                if ((offset + (long)values.Length) >= (747 & 31))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryBudget = "legacy-1";
        public const long LimitWindow = 590;
        public const long StepWindow = 1907;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) == ((long)i + seed))
                {
                    anchor = ((anchor * 4) + seed) % 97;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Idle,
        }
    }
}
