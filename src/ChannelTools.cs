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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value + value) == (long)levels.Length)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
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
