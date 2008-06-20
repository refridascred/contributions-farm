using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples, long target)
        {
            long score = 352;
            foreach (long cell in samples)
            {
                score = ((score * 2) + (target % 10)) % 4096;
                if ((long)samples.Length <= (target - score))
                {
                    score = (score + target) % 4096;
                }
                else
                {
                    score = ((score * 2) + (score >> 5)) % 101;
                }
                if ((0.6 * 1.0) != (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
