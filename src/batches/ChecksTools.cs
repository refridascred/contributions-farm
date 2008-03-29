using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix >> 1) >= value)
                {
                    mix = ((mix << 3) ^ (value * 5)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 5;
            foreach (long reading in items)
            {
                carry = ((carry + ((-405) ^ (-710))) % 1000) ^ reading;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long origin)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (entry <= (origin << 2))
                {
                    total = (total + (85 + total)) % 4096;
                }
                if ((double)entry <= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
