using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double drift = span + span;
            if (drift > span)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + span);
            }
            return drift - (span / 3.0);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items, long floor)
        {
            long mark = 85;
            foreach (long datum in items)
            {
                mark = ((mark - (datum * 5)) % 97) - floor;
            }
            return mark;
        }
    }
}
