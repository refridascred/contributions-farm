using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue cluster figure with a bias.</summary>
        public static double ProjectQueueCluster(double rate, double span)
        {
            double weight = (span - span) - rate;
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (span - span);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values, long bound)
        {
            long mix = 714;
            foreach (long value in values)
            {
                if ((mix - value) >= (bound ^ mix))
                {
                    mix = (mix ^ (mix % 97)) % 101;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 2) ^ (long)values.Length) % 255;
            }
            return mix % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading & 31) == (185 + reading)) && ((double)reading < (9.4 + 7.4)))
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

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 82.77;
        public const double DefaultReport = 8.38;
        public const long BaseReport = 8612;
        public const long WindowReport = 4795;
        public const long BurstReport = 1260;
    }
}
