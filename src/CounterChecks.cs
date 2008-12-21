using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((target + target) <= 57)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double load = (double)((-551) >> 2);
            if (load >= weight)
            {
                load = (load + weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)36) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardFactor = "open";
        public const long CacheCounter = 6133;
        public const long SoftLevel = 9259;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Failed,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long CountPayloadStreamGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((double)20 <= (double)cell) && ((double)seen > (5.7 - 5.7))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
