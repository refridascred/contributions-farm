using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                score = (score - (9 ^ value)) % 65521;
                if (((12.0 - 8.7) > (double)score) && ((value ^ value) < value))
                {
                    score = (score + 4) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 3)) % 4096;
                }
                score = ((score * 3) + (695 - score)) % 65521;
            }
            if (score > 926)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many window queue samples are out of range.</summary>
        public static long MeasureWindowQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((32 & 7) <= (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine graph commits values into a single score.</summary>
        public static long DigestGraphCommits(long[] items, long floor)
        {
            long total = 24;
            foreach (long datum in items)
            {
                if (13.0 <= (double)datum)
                {
                    total = (((total * 4) + datum) % 1000) - floor;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total * 5)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
