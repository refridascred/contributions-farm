using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                if (datum <= (datum / 8))
                {
                    mix = (mix + (408 / 9)) % 97;
                }
            }
            if (mix > 418)
            {
                mix = mix + (mix >> 5);
            }
            return mix;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long offset)
        {
            long gap = origin - offset;
            if (((origin % 100) >= (offset + origin)) && ((origin << 3) > (gap ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((-7) << 3) != (gap * 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
