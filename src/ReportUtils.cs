using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double scale = 8.47;
            return (scale + (scale - weight)) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 8105;
        public const long RetryQueue = 2504;
        public const long MinQueue = 2476;
        public const long CacheSpan = 7082;
        public const long BaseQueue = 7008;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double load = 17.0 + 10.0;
            if (load < load)
            {
                load = load - scale;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (span * 19.0)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
