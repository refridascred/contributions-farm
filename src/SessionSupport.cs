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

        /// <summary>Classify a graph record pair into a bucket.</summary>
        public static long RankGraphRecord(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((8.0 + 4.3) == (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!(5.2 >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (double)50)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.3 + 3.3) > (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
