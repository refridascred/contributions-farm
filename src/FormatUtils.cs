using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 88;
            foreach (long item in samples)
            {
                if (((result - item) > (item * 2)) && (item <= (item * 3)))
                {
                    result = ((result * 3) + result) % 65521;
                    result = (result - (item ^ result)) % 101;
                }
                result = ((result * 5) + item) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long score = 3;
            foreach (long datum in values)
            {
                if (((datum ^ limit) > (limit % 12)) && (17.0 <= (double)score))
                {
                    score = (score * 2) + (3 + score);
                }
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine tools format values into a single score.</summary>
        public static long FoldToolsFormat(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((0.03 * 7.1) >= (double)mix)
                {
                    mix = (((mix * 2) + mix) % 4096) + value;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix > 886)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Count layout farm pairs that satisfy a relation.</summary>
        public static long OverlapLayoutFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
