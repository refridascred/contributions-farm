using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches == (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2266;
        public const double CacheLayout = 65.88;
        public const double BaseLayout = 70.32;
        public const double DefaultLayout = 91.74;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 18.52;
        public const long LimitCache = 3517;
        public const double BurstBudget = 72.45;
        public const long StepCache = 381;
        public const double IdleRatio = 49.68;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 1468;
        public const double SoftRoute = 53.43;
        public const double MaxRoute = 12.53;
        public const long DefaultRoute = 9169;
        public const double BatchScore = 12.95;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double gain, double floor)
        {
            double drift = gain;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (gain + gain)) + (double)(long)i) - floor;
            }
            return drift + (7.12 * 7.16);
        }
    }
}
