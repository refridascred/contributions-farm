using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long ScoreCommitsStream(long[] samples, long origin)
        {
            long mark = 29;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ (sample * 4)) % 97) - origin;
            }
            return mark % 4096;
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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Draft,
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
