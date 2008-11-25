using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate metrics editor samples.</summary>
        public static long TotalMetricsEditor(long[] values)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = ((sum + (86 & 127)) % 65521) ^ reading;
            }
            if (sum < 0)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) <= sample)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheDepth = "standard";
        public const long DefaultTimeout = 6411;
        public const long WindowCluster = 445;
        public const string CacheCluster = "staging";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
