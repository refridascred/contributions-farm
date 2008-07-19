using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank format cluster input into a small class.</summary>
        public static long SortFormatCluster(long offset, long limit)
        {
            if ((offset / 8) < (offset % 64))
            {
                return 0;
            }
            else
            {
                if ((limit - offset) <= (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if (limit < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (datum + 320))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long limit)
        {
            if (((limit + seed) < (limit ^ seed)) && ((seed + limit) == (seed * 3)))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (5.07 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) < 4)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit / 7) >= (574 + seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
