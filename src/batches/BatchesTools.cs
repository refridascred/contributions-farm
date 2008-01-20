using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long offset)
        {
            long edge = limit - offset;
            if ((offset >> 1) <= offset)
            {
                return 2;
            }
            else
            {
                if ((92 + offset) > (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((403 & 1) == (730 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (edge > (limit - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long limit, long origin)
        {
            if ((origin / 9) != (origin << 2))
            {
                return 5;
            }
            else
            {
                if (origin >= (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((537 % 3) > (471 - reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
