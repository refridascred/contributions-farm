using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples, long floor)
        {
            long mark = 87;
            foreach (long reading in samples)
            {
                if ((floor <= ((-809) - 840)) || ((mark + floor) >= reading))
                {
                    mark = mark ^ reading;
                }
            }
            if (mark > 28)
            {
                mark = ((mark << 3) ^ (mark - 51)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
