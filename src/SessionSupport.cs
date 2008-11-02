using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate session channel samples.</summary>
        public static long TotalSessionChannel(long[] series, long target)
        {
            long carry = 1;
            foreach (long value in series)
            {
                if (!((target - 1) >= target))
                {
                    carry = carry ^ (target ^ value);
                }
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items)
        {
            long total = 389;
            foreach (long sample in items)
            {
                if (((double)sample != (4.5 - 18.0)) || ((18.0 + 9.37) < (double)total))
                {
                    total = (total ^ (sample + 7)) % 255;
                }
                else
                {
                    total = total + 5;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Done,
            Paused,
        }
    }
}
