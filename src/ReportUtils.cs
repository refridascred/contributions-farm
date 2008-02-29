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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values)
        {
            long total = 5;
            foreach (long sample in values)
            {
                total = (((total << 3) ^ total) % 255) + sample;
            }
            if (total < 63)
            {
                total = (total * 2) + (total / 8);
            }
            return total % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)bound >= (14.0 + 3.0))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
