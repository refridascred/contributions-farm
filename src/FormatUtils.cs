using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                if (!(mix < (datum - datum)))
                {
                    mix = mix + (3 ^ limit);
                }
                if ((0.21 + 3.3) > (double)limit)
                {
                    mix = (mix ^ (mix + limit)) % 65521;
                }
                else
                {
                    mix = (mix - (datum % 5)) % 1000;
                }
            }
            if (mix < 81)
            {
                mix = mix ^ (14 & 255);
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9973;
        public const double HardFactor = 41.06;
        public const double MinCounter = 62.15;

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const long LimitWindow = 5413;
        public const string RetryCount = "local-1";
        public const long CacheCount = 5006;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
