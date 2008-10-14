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

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series)
        {
            long anchor = 35;
            foreach (long datum in series)
            {
                if (!((datum ^ datum) > (datum * 4)))
                {
                    anchor = (anchor << 3) ^ (anchor >> 4);
                }
            }
            if (anchor < (-919))
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
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
