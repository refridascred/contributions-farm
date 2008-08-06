using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = 8;
            foreach (long reading in samples)
            {
                mark = ((mark << 3) ^ (3 % 3)) ^ reading;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((319 >> 1) >= carry))
                {
                    carry = ((carry * 2) + carry) % 4096;
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ (target * 3)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
