using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxFactor = 7649;
        public const string SoftBuffer = "strict";
        public const string IdleBuffer = "stable";
        public const long LimitBuffer = 7684;
        public const long RetryScore = 1806;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 3758;
        public const long MaxEntry = 3911;
        public const long MinLevel = 983;
        public const double BurstInterval = 67.98;
        public const long LimitEntry = 5613;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen < (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double scale = rate + (double)732;
            if (scale >= (double)0)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (rate - rate);
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 809;
            foreach (long datum in readings)
            {
                score = score ^ (datum - datum);
            }
            if (score < 75)
            {
                score = score ^ (score ^ score);
            }
            return score % 1000;
        }
    }
}
