using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (bound > (entry >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long offset2)
        {
            if (!((offset % 16) > 61))
            {
                return 4;
            }
            else
            {
                if ((576 * 3) > offset2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches >= sample) || ((double)sample != (6.6 + 7.7))) || (((matches / 2) >= (29 / 3)) && ((double)matches <= 6.65)))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
