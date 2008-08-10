using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            if (((bound << 2) == (bound - offset)) && ((bound / 9) == (offset + bound)))
            {
                return 4;
            }
            else
            {
                if (((offset ^ bound) <= offset) || (75 < (offset % 5)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (7.5 - 7.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a token queue pair into a bucket.</summary>
        public static long BucketTokenQueue(long seed, long bound)
        {
            if (((double)bound < (0.9 * 4.0)) && ((bound % 60) < 5))
            {
                return 4;
            }
            else
            {
                if (!(141 < bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound / 8) != (492 + 858))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((82 + bound) <= (seed + bound)) || ((8.4 * 5.0) >= (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
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
