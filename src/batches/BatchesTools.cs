using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally != (7.43 + 8.77))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 74;
            foreach (long item in readings)
            {
                long prev = ((long)readings.Length % 64) + mark;
                if (((long)readings.Length < (item + item)) && (mark > 39))
                {
                    mark = ((mark << 2) ^ (item + prev)) % 1000;
                }
                if (((mark / 3) >= item) && (mark > (4 ^ 7)))
                {
                    mark = (mark << 3) ^ item;
                }
                else
                {
                    mark = (mark << 2) ^ (mark / 3);
                }
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((edge % 12) > (edge ^ offset))
            {
                return 1;
            }
            else
            {
                if ((edge >> 2) > 1)
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (12.0 * 18.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
