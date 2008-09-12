using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                if (((2.6 - 8.81) <= (double)entry) && ((double)offset < (6.7 + 13.0)))
                {
                    carry = ((carry * 4) + 582) % 101;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 3) + (offset * 5);
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long score = -16;
            foreach (long item in items)
            {
                if ((item - item) == (3 % 16))
                {
                    score = score - (72 * 3);
                }
                else
                {
                    score = (score ^ (item + item)) % 97;
                }
                if (((-5) & 127) >= (item >> 3))
                {
                    score = (score - (7 << 2)) % 4096;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
            }
            if (score > 550)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
