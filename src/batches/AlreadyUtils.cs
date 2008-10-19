using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long CountChecksStreamHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum < (matches / 2))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.0 <= (double)sample) && (count >= (sample + sample)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((step + step) < 8) && ((double)tally >= (double)7))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel cache pair into a bucket.</summary>
        public static long ClassifyChannelCache(long limit, long bound)
        {
            long step = limit - bound;
            if (limit >= (bound + 17))
            {
                return 6;
            }
            else
            {
                if (6.9 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((6 + step) > ((-3) + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) <= bound)
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
        }
    }
}
