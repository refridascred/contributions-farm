using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item * 3) <= floor) || ((double)hits < (0.4 - 4.1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long floor, long origin)
        {
            if ((floor << 2) >= (origin / 9))
            {
                return 5;
            }
            else
            {
                if ((floor * 4) > floor)
                {
                    return 1;
                }
                else
                {
                    if (17.0 > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.18 + 1.0) >= (double)floor) && ((double)floor < (2.5 * 8.7)))
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
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                if (5.5 < (double)sum)
                {
                    sum = (sum ^ 81) % 1000;
                }
                if ((double)datum < (10.0 / 9.0))
                {
                    break;
                }
            }
            if (sum > (-6))
            {
                sum = (sum + (3 + sum)) % 4096;
            }
            return sum;
        }
    }
}
