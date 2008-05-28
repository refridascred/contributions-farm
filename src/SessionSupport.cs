using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit checks batches readings against a rule.</summary>
        public static long AuditChecksBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen << 2) > reading) && (((double)reading > (3.0 * 7.0)) && ((seen + reading) <= (3 - reading))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long carry = 733;
            foreach (long value in levels)
            {
                if ((carry & 255) > carry)
                {
                    carry = carry ^ value;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry / 9)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
