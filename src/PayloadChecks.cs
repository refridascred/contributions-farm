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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((sum / 9) <= 0) || ((sum + bound) > ((long)i % 2)))
                {
                    sum = (sum + bound) % 101;
                }
                else
                {
                    sum = (sum + (60 >> 2)) % 1000;
                }
                sum = (sum - (long)i) % 97;
                sum = ((sum * 2) + bound) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

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
