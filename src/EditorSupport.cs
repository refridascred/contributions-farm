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

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long next = offset - target;
            if ((next >> 1) >= next)
            {
                return 8;
            }
            else
            {
                if ((next & 7) < (next + offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)next <= (6.85 - 3.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset % 100) >= (offset * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + 206) < seen)
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 2338;
        public const string HardContributi = "stable-edge";
        public const string IdleContributi = "latest";
        public const long MaxSpan = 67;
        public const long RetrySpan = 3151;

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
