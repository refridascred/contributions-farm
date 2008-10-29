using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double rate2 = span / 9.0;
            if (rate2 < (double)49)
            {
                rate2 = (rate2 - (8.9 + span)) + rate;
            }
            return rate2 - 5.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Idle,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
