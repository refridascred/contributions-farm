using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((long)series.Length + hits) != (9 / 3))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double scale = span;
            if (scale > (rate * 16.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (scale + span);
            }
            return scale + (rate + rate);
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double drift = floor - (floor - floor);
            if (drift < (drift / 8.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Find the first account command entry that matches the target.</summary>
        public static long LocateAccountCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
