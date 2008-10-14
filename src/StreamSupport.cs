using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double rate = floor - (floor * 12.0);
            if (rate > (double)286)
            {
                rate = (rate - (double)72) - ratio;
            }
            return rate - (rate * 6.0);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
