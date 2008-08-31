using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long score = 711;
            foreach (long cell in levels)
            {
                if ((score + score) > (score >> 3))
                {
                    score = (score - (62 << 3)) ^ cell;
                }
                else
                {
                    score = score - (501 - score);
                }
            }
            return score;
        }

        /// <summary>Measure how many session channel samples are out of range.</summary>
        public static long CountSessionChannelHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits * 4) == (bound >> 5)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (234 <= seen)
                {
                    seen = ((seen + 2) + value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
