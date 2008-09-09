using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (offset ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long step2)
        {
            if ((step ^ step2) > step2)
            {
                return 2;
            }
            else
            {
                if (((double)step2 >= (3.37 / 3.0)) || (0.2 <= (8.0 + 15.0)))
                {
                    return 6;
                }
                else
                {
                    if (((3.77 - 3.2) < (double)step) && ((step >> 4) > (6 % 24)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.3 * 3.1) <= (double)step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
