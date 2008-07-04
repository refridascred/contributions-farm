using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long anchor = 575;
            foreach (long datum in items)
            {
                anchor = (anchor * 3) + (datum + 706);
                if (step >= (step / 2))
                {
                    anchor = (anchor ^ ((-2) - datum)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = ((sum * 3) + (reading >> 4)) % 255;
                if (20 <= (reading >> 2))
                {
                    sum = (sum * 3) + ((long)series.Length * 4);
                }
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            New,
            Active,
        }
    }
}
