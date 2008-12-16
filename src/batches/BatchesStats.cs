using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                score = score - (entry + (-5));
                if ((double)entry <= (4.3 * 6.71))
                {
                    break;
                }
            }
            if (score > (-7))
            {
                score = (score + score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            New,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long origin)
        {
            long mark = -979;
            foreach (long item in items)
            {
                if ((mark + origin) == (origin * 2))
                {
                    mark = ((mark + mark) % 101) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((651 + 70) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
