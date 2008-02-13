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

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double weight = (double)(319 % 16);
            if (weight < (scale * 7.1))
            {
                weight = weight - (double)63;
            }
            else
            {
                weight = weight + (span + 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (1.1 - 5.6)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long CountMetricCommitsGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= (target / 9))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
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
