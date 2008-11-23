using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardFactor = "cached";
        public const long RetryContributi = 1735;
        public const double BurstLevel = 19.78;

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double SmoothReportGraph(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Done,
            Paused,
            Active,
        }
    }
}
