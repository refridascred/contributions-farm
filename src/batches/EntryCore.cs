using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            return mean + (bias / 6.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 8217;
        public const long SoftLevel = 9833;
        public const double WindowProfile = 93.83;
        public const long BaseScore = 311;
        public const double RetryRatio = 15.81;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            New,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
