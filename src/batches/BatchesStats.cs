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

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                if ((anchor >> 5) >= (value - (-66)))
                {
                    anchor = (anchor + (value * 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + value) % 4096;
                }
                if ((anchor - anchor) >= (0 ^ 0))
                {
                    anchor = (anchor << 3) ^ (value / 4);
                }
                else
                {
                    anchor = ((anchor * 4) + (value / 9)) % 1000;
                }
            }
            return anchor % 4096;
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
