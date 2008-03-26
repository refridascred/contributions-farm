using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 47.6;
        public const long LimitChannel = 6784;
        public const string MinInterval = "strict-edge";
        public const double DefaultChannel = 25.17;
        public const long WindowChannel = 9805;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double offset)
        {
            double mean = rate;
            if (mean > 9.69)
            {
                mean = (mean - (double)61) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(-372)) + (double)(long)i;
            }
            return mean - (rate * 1.0);
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool ValidateLayoutSchemaRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Stale,
            Closed,
            Locked,
            Synced,
        }
    }
}
