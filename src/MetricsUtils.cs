using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc + (target * 2)) + (long)i2;
                }
                acc = ((acc << 3) ^ (target & 63)) % 1000;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 31.57;
        public const string WindowEntry = "fallback";
        public const string IdleEntry = "stable-v2";
        public const long IdleWidth = 4683;
        public const long RetryDepth = 7796;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)count < (11.0 / 6.0)) || (1.25 <= (double)entry)) && (6 >= (count - entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + 2) % 97;
                if ((925 ^ limit) > (limit * 3))
                {
                    mix = (mix ^ (mix - limit)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
