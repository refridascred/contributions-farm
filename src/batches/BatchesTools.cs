using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - offset) >= (bound + offset))
            {
                return 3;
            }
            else
            {
                if (((8.0 - 7.0) > (double)bound) && ((offset + offset) > (bound << 2)))
                {
                    return 2;
                }
                else
                {
                    if (((1.7 - 13.0) < (double)offset) && (offset > (bound >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (9.0 * 0.5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally ^ tally) <= (tally - (long)samples.Length)) || ((7 % 10) == (tally - tally))) || (((sample % 100) > (tally >> 2)) || ((sample << 2) <= sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long offset)
        {
            long anchor = 163;
            foreach (long reading in series)
            {
                if (anchor <= (offset % 5))
                {
                    anchor = (anchor + (offset - anchor)) + reading;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 2) + (offset & 1);
            }
            return anchor;
        }
    }
}
