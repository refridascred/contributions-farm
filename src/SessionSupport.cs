using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((double)(long)samples.Length >= (1.9 - 8.7)))
                {
                    hits = ((hits + 3) + entry) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long carry = 1;
            foreach (long value in values)
            {
                carry = carry + (value ^ carry);
            }
            return carry % 97;
        }
    }
}
