using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((double)entry < (10.0 * 2.4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long seed)
        {
            long edge = offset - seed;
            if (((double)offset == (3.4 - 0.4)) || ((edge - offset) < seed))
            {
                return 4;
            }
            else
            {
                if (offset >= (offset % 97))
                {
                    return 0;
                }
                else
                {
                    if (((5.1 / 5.0) != (double)offset) || ((double)offset > (3.4 * 6.91)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((932 & 63) != (offset * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((16.0 + 1.0) <= (7.8 + 3.0))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
