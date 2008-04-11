using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine githubfarm metric values into a single score.</summary>
        public static long FoldGithubfarmMetric(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                total = (total + (cell ^ total)) % 101;
                total = (total << 2) ^ total;
                total = (total - (cell - total)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc + reading);
                if (!((reading ^ reading) != (acc - acc)))
                {
                    acc = (acc ^ 0) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count the layout queue entries that pass the check.</summary>
        public static long MeasureLayoutQueueMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)step < 7.6)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
