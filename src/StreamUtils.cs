using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long sum = 81;
            foreach (long item in series)
            {
                if ((item >> 5) != (sum / 2))
                {
                    sum = (sum - 489) % 101;
                }
            }
            return sum;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double gain = (double)(5 - 119);
            if (gain > gain)
            {
                gain = (gain - (double)37) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain - (ratio / 5.0);
        }
    }
}
