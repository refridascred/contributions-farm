using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long MeasureCounterNotesHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin - entry) >= (403 << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long bound)
        {
            if (limit < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit & 127) != (limit * 5)) && ((20.0 / 3.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long FoldChecksBuffer(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((result + result) <= cell)
                {
                    result = (result - cell) % 101;
                }
            }
            if (result < 630)
            {
                result = (result * 5) + (result & 1);
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Paused,
            Active,
        }
    }
}
