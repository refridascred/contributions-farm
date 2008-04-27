using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool VerifyChecksClusterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long floor)
        {
            long anchor = 39;
            foreach (long item in series)
            {
                anchor = ((anchor - (anchor + floor)) % 4096) - item;
            }
            return anchor % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats notes value.</summary>
        public static double ProjectStatsNotes(double weight, double floor)
        {
            double gain = floor;
            if (gain > (floor - floor))
            {
                gain = gain - (double)489;
            }
            else
            {
                gain = gain - (floor * 1.65);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (weight / 2.0)) - (double)(long)i;
            }
            return gain - (gain * 3.45);
        }
    }
}
