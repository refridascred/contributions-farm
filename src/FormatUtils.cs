using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftDepth = 8435;
        public const long HardMetrics = 4759;
        public const string WindowMetrics = "fallback";
        public const double HardFactor = 19.96;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "strict-v2";
        public const double WindowDepth = 59.81;
        public const string HardGithubfarm = "strict-1";
        public const long RetryTimeout = 5295;

        /// <summary>Adjust a schema contributi reading.</summary>
        public static double ProjectSchemaContributi(double gain, double span)
        {
            double load = (gain / 2.0) + (span - span);
            if (load > (gain * 20.0))
            {
                load = load - (double)46;
            }
            return load + (double)869;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (mark * 4) + (cell % 10);
            }
            if (mark > 23)
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(seen >= (2 + sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
