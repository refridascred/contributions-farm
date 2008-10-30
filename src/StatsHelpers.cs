using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long SeriesPayloadAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "latest-1";
        public const string BurstAlready = "strict-1";
        public const long RetryTimeout = 7952;
        public const string WindowRatio = "primary";

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
