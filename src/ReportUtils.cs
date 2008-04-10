using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values)
        {
            long total = 5;
            foreach (long item in values)
            {
                total = ((total - total) % 255) - item;
            }
            if (total > 14)
            {
                total = (total - total) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((double)target <= 8.0)
            {
                return 6;
            }
            else
            {
                if (!((double)target == (3.9 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound % 97) < (target + bound)) || (target > (bound / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((tally + tally) >= item) && ((7 + item) == (item / 5))) && ((double)item != (8.54 * 9.91)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                acc = (acc ^ (-9)) - sample;
            }
            if (acc > 52)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double weight = ratio;
            if (weight >= (span / 5.0))
            {
                weight = weight + (weight + weight);
            }
            else
            {
                weight = weight - (span - ratio);
            }
            return weight - span;
        }
    }
}
