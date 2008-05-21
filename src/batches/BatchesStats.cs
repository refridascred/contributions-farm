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

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSpan = 9736;
        public const long BaseStream = 699;
        public const long BatchSpan = 5808;
        public const long HardStream = 1808;
        public const string WindowStream = "cached-1";

        /// <summary>Find the first command report entry that matches the target.</summary>
        public static long FindCommandReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
