using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long target)
        {
            long delta = offset - target;
            if (delta < offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset < (4.85 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if (delta > (offset ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((delta * 2) == (1 - target)) && ((double)delta < (7.5 * 3.33)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) == (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
