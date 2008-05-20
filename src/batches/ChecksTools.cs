using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.5 * 1.9))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                    carry = ((carry * 5) + carry) % 101;
                }
                carry = ((carry << 3) ^ carry) % 65521;
                if ((1.3 * 5.6) <= (double)94)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long step)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                score = ((((score << 2) ^ score) % 101) ^ cell) - step;
            }
            return score;
        }
    }
}
