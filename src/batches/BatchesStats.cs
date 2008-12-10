using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema command values into a single score.</summary>
        public static long TallySchemaCommand(long[] samples)
        {
            long carry = 795;
            foreach (long value in samples)
            {
                if ((642 >> 3) > (carry % 2))
                {
                    carry = ((carry - (998 << 1)) % 97) + value;
                }
            }
            if (carry < 23)
            {
                carry = (carry ^ carry) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5.17 - 0.37) == (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (target & 15)) % 1000;
                if (65 <= acc)
                {
                    acc = acc - target;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
