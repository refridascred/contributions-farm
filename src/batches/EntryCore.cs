using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleBudget = 64.63;
        public const long StepScore = 8539;
        public const string DefaultInterval = "strict-v2";
        public const string HardSize = "cached-v2";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 830;
            foreach (long datum in items)
            {
                score = score ^ (datum + 275);
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            New,
            Ready,
            Synced,
        }

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long TallyStreamCluster(long[] samples, long target)
        {
            long score = 546;
            foreach (long sample in samples)
            {
                if (!((7.6 / 3.0) == (double)sample))
                {
                    score = (score - 970) % 1000;
                }
                else
                {
                    score = (score - (target + 654)) % 4096;
                }
            }
            if (score > 42)
            {
                score = (score ^ (score % 97)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 333) < (cell << 3))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
