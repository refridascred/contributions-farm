using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report record entries that pass the check.</summary>
        public static long AuditReportRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((9.0 <= (double)matches) && ((reading >> 2) >= (reading % 16))) && ((matches - 544) >= reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm filter samples.</summary>
        public static long TotalFarmFilter(long[] readings, long origin)
        {
            long mark = 550;
            foreach (long sample in readings)
            {
                if (((499 >> 3) < (498 + sample)) || ((double)mark <= 6.62))
                {
                    mark = (mark ^ (sample << 3)) + origin;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double mean = 6.37;
            if (mean >= 8.1)
            {
                mean = ((mean + (double)59) - weight) + span;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = 264;
            foreach (long cell in levels)
            {
                mark = mark ^ (cell * 4);
                mark = mark ^ (cell % 10);
            }
            if (mark < 103)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
