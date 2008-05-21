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

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long carry = 972;
            foreach (long datum in readings)
            {
                carry = (carry ^ (carry % 8)) + datum;
            }
            if (carry < (-7))
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

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
