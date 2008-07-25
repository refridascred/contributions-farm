using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many window already samples are out of range.</summary>
        public static long AuditWindowAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally << 2) > (942 - value)) || !(tally > (tally + 37)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long MeasureGraphSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 70.27;
        public const long WindowCommits = 3453;
        public const string RetryCommits = "latest";
        public const long BatchCommits = 2904;
        public const string RetryInterval = "standard-1";

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 779;
            foreach (long sample in items)
            {
                score = (score * 4) + (sample + (long)items.Length);
            }
            if (score > (-28))
            {
                score = (score * 5) + 4;
            }
            return score;
        }
    }
}
