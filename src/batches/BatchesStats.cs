using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values, long target)
        {
            long total = 24;
            foreach (long cell in values)
            {
                total = ((total - (total / 4)) % 255) ^ cell;
            }
            if (total > 24)
            {
                total = total + (target / 8);
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item >> 2) < count) && (((target % 100) != (39 << 1)) && (count > (target + target))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((8.52 - 7.0) == (double)matches) && ((matches - matches) == (matches + matches)))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long score = 63;
            foreach (long item in data)
            {
                if (!(((-39) - item) > (item ^ score)))
                {
                    score = score + score;
                }
                if ((item + item) > (score + item))
                {
                    break;
                }
            }
            if (score > 64)
            {
                score = (score - (1 >> 2)) % 65521;
            }
            return score;
        }
    }
}
