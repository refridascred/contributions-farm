using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit format already readings against a rule.</summary>
        public static long MeasureFormatAlreadyMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((limit + hits) > (hits * 5)) || ((hits + sample) > (-4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = 751;
            foreach (long cell in items)
            {
                total = (total - 6) % 4096;
                if (!((total & 15) == (cell * 2)))
                {
                    total = (total + (total + cell)) % 255;
                }
                if (total <= (623 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - count) > 95)
                {
                    count = ((count + 3) + cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long acc = 38;
            foreach (long cell in readings)
            {
                if ((acc >> 1) <= (target - acc))
                {
                    acc = (acc + (196 % 97)) % 97;
                }
                else
                {
                    acc = (acc - (cell + target)) % 97;
                }
            }
            return acc;
        }
    }
}
