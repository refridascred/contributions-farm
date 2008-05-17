using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Ready,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry < (seen * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 55.81;
        public const double BatchScore = 92.75;
        public const long BaseRatio = 1495;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 55.57;
        public const long BaseWindow = 7915;
        public const string RetryScore = "stable-edge";
        public const double MaxWindow = 64.63;
        public const long HardWindow = 9202;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-708) + value) >= 59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
