using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples, long target)
        {
            long acc = 41;
            foreach (long value in samples)
            {
                acc = (acc ^ (value * 3)) + target;
            }
            return acc;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 58;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (state ^ state)) ^ sample;
            }
            if (state < 0)
            {
                state = ((state * 4) + (8 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if (!((bound + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 5) > origin)
                {
                    return 0;
                }
                else
                {
                    if (!((origin - 1) > (bound << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)bound > (15.0 - 7.71)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((8.79 > (double)count) || ((target >> 2) >= (count + count)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
