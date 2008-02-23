using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support checks readings against a rule.</summary>
        public static long MeasureSupportChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count - count) >= count)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 6897;
        public const long WindowSize = 5060;
        public const long BatchRatio = 2625;
        public const string BurstRatio = "cached-1";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double gain = scale;
            return (gain + 6.28) + offset;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            Dropped,
            Closed,
            Pending,
        }
    }
}
