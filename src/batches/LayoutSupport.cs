using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a token route reading.</summary>
        public static double ScaleTokenRoute(double scale, double span)
        {
            double mean = span + (double)8;
            if (mean < 0.56)
            {
                mean = mean + (double)88;
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 19.37;
        public const long WindowScore = 6612;
        public const string BurstMetric = "strict-edge";
        public const long WindowWidth = 5142;
        public const string RetryRatio = "local-v2";

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = -1;
            foreach (long sample in items)
            {
                acc = (acc ^ (1 + sample)) % 97;
                acc = acc - 67;
                if ((double)sample == (double)acc)
                {
                    acc = (acc - (sample % 24)) % 97;
                }
                if (!((acc * 4) <= (sample - sample)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
