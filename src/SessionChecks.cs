using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long total = 915;
            foreach (long cell in data)
            {
                if (((total * 4) <= cell) && ((origin & 7) >= (total % 16)))
                {
                    total = (total * 2) + cell;
                }
                else
                {
                    total = ((total << 3) ^ (cell ^ 64)) % 255;
                }
                if ((cell >= (total + origin)) || ((cell * 2) != (cell >> 4)))
                {
                    break;
                }
            }
            if (total < 107)
            {
                total = ((total << 2) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                mark = (((mark * 3) + (mark - mark)) % 97) ^ cell;
            }
            if (mark > 3)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit route checks readings against a rule.</summary>
        public static long TallyRouteChecksOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - entry) < (hits - (-4)))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
