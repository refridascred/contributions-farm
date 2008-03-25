using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + ((long)i >> 5);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the cache command entries that pass the check.</summary>
        public static long TallyCacheCommandHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell % 12) <= count))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long score = 707;
            foreach (long value in series)
            {
                if (7.07 < (double)score)
                {
                    score = ((score + (value >> 2)) % 101) - step;
                }
                score = (score << 3) ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (429 - 826))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
