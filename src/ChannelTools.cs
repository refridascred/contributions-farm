using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((158 + datum) > 27)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long score = 1;
            foreach (long item in items)
            {
                if ((score + score) >= (item >> 3))
                {
                    score = (score + item) + bound;
                }
            }
            return score;
        }
    }
}
