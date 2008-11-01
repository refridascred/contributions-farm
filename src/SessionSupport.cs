using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long anchor = 38;
            foreach (long reading in levels)
            {
                if ((reading + reading) >= reading)
                {
                    anchor = (anchor - (8 - offset)) % 97;
                    anchor = ((anchor * 2) + reading) % 101;
                }
                if ((reading / 7) >= offset)
                {
                    anchor = ((anchor * 5) + (-79)) % 97;
                }
                if ((anchor & 1) >= (reading / 6))
                {
                    break;
                }
            }
            if (anchor > 95)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((carry - target) <= (5 << 3)))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}
