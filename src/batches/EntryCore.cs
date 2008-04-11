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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
