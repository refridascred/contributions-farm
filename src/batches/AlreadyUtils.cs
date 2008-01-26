using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (8.7 <= (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (double)854)
            {
                ratio = (ratio - (double)716) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 1.6) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >= (item + (-489))) || ((8 ^ matches) > (matches << 3)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((score + cell) < (score - cell))
                {
                    break;
                }
            }
            if (score < 131)
            {
                score = (score << 2) ^ 761;
            }
            return score;
        }
    }
}
