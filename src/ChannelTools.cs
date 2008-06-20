using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double rate = (offset / 7.0) + (offset / 3.0);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (double)7) + (double)(long)i) - ratio;
            }
            return rate - rate;
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long CountTokenOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((150 * 5) < (seen << 3))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
