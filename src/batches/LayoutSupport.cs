using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Dropped,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Accumulate session order samples.</summary>
        public static long TotalSessionOrder(long[] samples)
        {
            long carry = 98;
            foreach (long value in samples)
            {
                carry = (carry - (value + carry)) % 4096;
                carry = (carry ^ (long)samples.Length) % 97;
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Pending,
            Done,
            Active,
            Closed,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long target)
        {
            if (10.0 >= (double)target)
            {
                return 4;
            }
            else
            {
                if (!((origin / 8) > (target - origin)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
