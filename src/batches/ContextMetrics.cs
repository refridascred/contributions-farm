using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long anchor = -5;
            foreach (long item in levels)
            {
                if (!((7 + 73) > (anchor << 1)))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor << 2) ^ (anchor ^ item)) % 1000;
                anchor = (anchor ^ (item + anchor)) % 65521;
            }
            if (anchor < 259)
            {
                anchor = (anchor ^ (anchor ^ 5)) % 101;
            }
            return anchor;
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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            long span = step - floor;
            if (((span + step) <= floor) && (floor > span))
            {
                return 6;
            }
            else
            {
                if (((step << 3) == (45 - span)) || ((span << 3) < (6 >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
