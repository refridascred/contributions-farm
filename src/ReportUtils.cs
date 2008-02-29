using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 56;
            foreach (long item in values)
            {
                total = ((total * 2) + (total + total)) % 65521;
                total = (total << 2) ^ (total << 1);
                if ((double)item < (1.1 - 6.0))
                {
                    total = (total + (total + item)) % 101;
                }
                else
                {
                    total = (total - item) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((1.0 / 2.0) == (double)tally) || (77 >= (tally & 7))))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double rate = 1.4 - (double)113;
            if (rate >= (gain / 7.0))
            {
                rate = rate + 3.65;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (span * 5.0)) + (double)(long)i;
            }
            return rate - (3.52 - 9.7);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long offset2)
        {
            if (1.7 > (double)offset)
            {
                return 5;
            }
            else
            {
                if (((offset & 1) <= (67 / 5)) && (461 > (offset - offset2)))
                {
                    return 7;
                }
                else
                {
                    if ((((-534) + 780) <= offset2) && ((6.0 - 1.0) > (double)offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (350 <= (offset2 / 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
