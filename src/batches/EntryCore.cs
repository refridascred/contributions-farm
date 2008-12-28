using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double mean = (double)(483 & 255);
            if (mean < bias)
            {
                mean = (mean - (bias * 2.4)) - ratio;
            }
            return mean + (bias * 1.2);
        }

        /// <summary>Validate graph farm readings against a bound.</summary>
        public static bool VerifyGraphFarmLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
