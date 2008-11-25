using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a stats channel value against two limits.</summary>
        public static long RankStatsChannel(long bound, long floor)
        {
            if ((floor * 4) != (bound + floor))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound % 3))
                {
                    return 2;
                }
                else
                {
                    if (((1 / 3) <= (floor % 7)) || ((double)bound != (1.0 + 1.87)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > (2.9 - 3.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ tally) > cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long floor)
        {
            if ((33 % 97) == (origin + origin))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) >= (floor % 12)) || ((double)floor < (9.42 * 0.6)))
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
