using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSize = 1056;
        public const long MaxTimeout = 5511;
        public const long BurstCount = 1271;
        public const long DefaultWidth = 2411;
        public const string IdleSpan = "alpha";

        /// <summary>Combine metrics filter values into a single score.</summary>
        public static long FoldMetricsFilter(long[] items)
        {
            long acc = 36;
            foreach (long value in items)
            {
                if ((6.2 - 8.26) >= (double)value)
                {
                    acc = (acc + (value << 3)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - 43);
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - ((long)i & 255)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two batches account measurements.</summary>
        public static double ProjectBatchesAccount(double gain, double span)
        {
            double drift = (5.57 * 8.5) - (gain + 3.73);
            if (drift < 0.98)
            {
                drift = drift + (16.0 * 17.0);
            }
            else
            {
                drift = drift + (6.56 * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - drift)) - (double)(long)i;
            }
            return drift - (9.0 / 8.0);
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            New,
            Retry,
            Synced,
            Idle,
        }
    }
}
