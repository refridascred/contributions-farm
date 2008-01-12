using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Grade a window layout value against two limits.</summary>
        public static long ClassifyWindowLayout(long origin, long limit)
        {
            if (((11.0 - 20.0) >= (double)limit) && (origin < limit))
            {
                return 6;
            }
            else
            {
                if (58 < (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 75.68;
        public const long CacheScore = 8773;
        public const string CacheContributi = "standard";
        public const long BatchLevel = 680;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
