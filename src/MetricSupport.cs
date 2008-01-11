using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long step)
        {
            if ((double)seed <= (6.94 + 5.17))
            {
                return 5;
            }
            else
            {
                if (!((16.0 + 9.4) > (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((622 >= (seed & 1)) || ((seed % 100) < seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((target - value) == (value << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long limit)
        {
            long bound2 = bound + limit;
            if (4.1 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((bound < ((-301) * 2)) || ((bound + limit) < (bound2 + 18)))
                {
                    return 0;
                }
                else
                {
                    if ((2 / 8) <= (bound * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (4.4 / 8.0))
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
    }
}
