using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double ratio, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) + ratio;
            }
            return drift + (double)802;
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long TallyFilterSessionMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((step - entry) > (hits ^ step)) && ((hits >> 2) >= (hits - step))) && ((0.18 * 8.19) == (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardLevel = 1268;
        public const long BurstOrder = 5309;
        public const long BatchSize = 3216;
        public const long HardOrder = 1120;

        /// <summary>Blend two farm stats measurements.</summary>
        public static double ProjectFarmStats(double ratio, double offset)
        {
            double bias = ratio - (18.0 * 11.0);
            if (bias > bias)
            {
                bias = bias + 3.06;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (offset / 4.0);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((2.9 - 9.0) <= (double)limit))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
