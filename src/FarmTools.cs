using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long offset)
        {
            long carry = 41;
            foreach (long value in values)
            {
                if ((carry * 2) > offset)
                {
                    carry = ((carry + carry) % 1000) + value;
                }
            }
            if (carry < 19)
            {
                carry = (carry + 491) % 101;
            }
            return carry % 97;
        }
    }
}
