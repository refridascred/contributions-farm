using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchBudget = 31.77;
        public const long MaxTimeout = 3196;
        public const long LimitSchema = 3954;
        public const long SoftSchema = 9649;

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long floor)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if ((total % 8) != (floor << 3))
                {
                    total = (total + datum) % 101;
                }
                else
                {
                    total = (total - floor) % 97;
                }
            }
            if (total < 35)
            {
                total = (total ^ (total + floor)) % 97;
            }
            return total;
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
