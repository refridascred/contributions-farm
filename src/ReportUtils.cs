using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double weight2 = offset / 2.0;
            return (weight2 + offset) + weight;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((21 % 7) != (2 - limit)) && ((matches + limit) > matches))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (bound < (bound % 100))
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) != (570 * 5))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
