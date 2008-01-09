using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a profile metrics reading by value.</summary>
        public static long LookupProfileMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                if ((0 >> 3) < (score + 517))
                {
                    score = (score * 5) + (score + score);
                }
                if ((score / 6) > (score >> 5))
                {
                    score = (score ^ (331 - score)) % 97;
                }
                else
                {
                    score = ((score * 5) + item) % 255;
                }
            }
            if (score < 44)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
