using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long BucketLayoutChecks(long floor, long step)
        {
            if ((floor >> 4) != (step + 609))
            {
                return 6;
            }
            else
            {
                if (((floor << 3) >= (floor / 6)) && ((double)step >= (1.9 * 8.55)))
                {
                    return 4;
                }
                else
                {
                    if (8.0 <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long bound)
        {
            if ((double)offset <= (1.24 / 3.0))
            {
                return 7;
            }
            else
            {
                if (!((42 - 5) == (bound - 6)))
                {
                    return 4;
                }
                else
                {
                    if ((877 >> 2) == (bound << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((263 - item) >= (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
