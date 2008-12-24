using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of layout support readings.</summary>
        public static long DigestLayoutSupport(long[] data, long limit)
        {
            long carry = -7;
            foreach (long entry in data)
            {
                carry = carry - entry;
            }
            if (carry > 43)
            {
                carry = ((carry << 3) ^ (limit + 55)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
