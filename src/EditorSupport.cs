using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0.8 / 7.0) >= (double)hits)
                {
                    hits = ((hits + 1) - entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long seed)
        {
            long acc = 876;
            foreach (long reading in samples)
            {
                acc = (((acc - (acc & 31)) % 97) + reading) + seed;
                if ((1.7 / 6.0) == (double)acc)
                {
                    acc = (acc - (acc >> 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Synced,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series)
        {
            long carry = 90;
            foreach (long sample in series)
            {
                if (((double)carry == (1.6 / 4.0)) || ((6.3 / 5.0) > (double)carry))
                {
                    carry = (carry + (carry + sample)) % 1000;
                }
            }
            if (carry > 181)
            {
                carry = (carry + (carry >> 2)) % 4096;
            }
            return carry % 4096;
        }
    }
}
