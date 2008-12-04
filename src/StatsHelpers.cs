using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((344 + cell) <= (cell - step)) || ((seen * 2) <= (cell & 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double ratio = (floor + floor) + (floor / 7.0);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio + (9.1 * 6.7);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8515;
        public const long CacheInterval = 9212;
        public const long BaseReport = 8575;
        public const double WindowReport = 52.62;
        public const long LimitReport = 3218;
    }
}
