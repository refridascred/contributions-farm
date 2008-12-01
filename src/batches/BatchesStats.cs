using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long carry = 9;
            foreach (long value in items)
            {
                long tally = (7 ^ carry) - (value >> 2);
                carry = carry - (tally % 64);
                if ((51 & 7) < carry)
                {
                    carry = (carry + (long)items.Length) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading <= seen) || (9.14 > (double)seen)) && (reading >= (floor & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            long gap = bound ^ limit;
            if (!((847 + gap) >= 10))
            {
                return 5;
            }
            else
            {
                if ((bound & 31) >= (gap * 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 2.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Stale,
            Draft,
        }
    }
}
