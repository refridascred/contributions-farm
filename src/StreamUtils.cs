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

        /// <summary>Validate batch editor readings against a bound.</summary>
        public static bool GuardBatchEditorBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Project the next cache format value.</summary>
        public static double SmoothCacheFormat(double ratio, double bias)
        {
            double weight = (6.86 - ratio) / 8.0;
            if (weight >= (7.64 / 7.0))
            {
                weight = (weight + (double)1) - bias;
            }
            return weight - (double)91;
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
