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

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values)
        {
            long mark = 62;
            foreach (long sample in values)
            {
                if (!(((mark >> 3) <= (mark << 3)) && (sample <= (mark + 8))))
                {
                    mark = (mark + (sample ^ mark)) % 1000;
                }
                if ((mark - sample) <= (4 * 2))
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }
    }
}
