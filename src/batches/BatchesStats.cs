using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long bound, long offset)
        {
            long offset2 = bound + offset;
            if (((offset ^ offset) >= offset) || ((double)offset <= (4.21 - 2.2)))
            {
                return 3;
            }
            else
            {
                if ((offset + bound) >= 442)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset2 >= (double)492)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + offset) == (offset >> 4))
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

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (((prev / 5) >= 2) && ((76 + floor) != (floor + floor)))
            {
                return 4;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 7;
                }
                else
                {
                    if ((5.83 * 4.8) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (90 >= (limit * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 9543;
        public const long BurstToken = 3884;
        public const long MaxToken = 4532;
        public const long StepInterval = 8190;
        public const string RetryToken = "cached-v2";
    }
}
