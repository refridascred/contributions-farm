using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= 30)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] samples)
        {
            long total = 248;
            foreach (long value in samples)
            {
                if ((value - value) == (total ^ 810))
                {
                    total = total + (total - total);
                }
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long carry = 14;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry + limit)) % 97;
            }
            if (carry < (-10))
            {
                carry = ((carry * 3) + (carry + limit)) % 97;
            }
            return carry;
        }
    }
}
