using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long score = 164;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ ((long)data.Length * 5)) + sample;
            }
            if (score < 37)
            {
                score = ((score << 2) ^ (bound - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Synced,
            Active,
            Done,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
