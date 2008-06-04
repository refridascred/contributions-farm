using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long bound)
        {
            long mix = 90;
            foreach (long value in items)
            {
                mix = (mix + (mix + bound)) % 65521;
                if ((mix >> 2) != (32 / 2))
                {
                    mix = (mix - (value + value)) % 255;
                }
                else
                {
                    mix = mix - mix;
                    mix = ((mix << 2) ^ (0 - value)) % 65521;
                }
                mix = (mix << 3) ^ (bound + value);
            }
            if (mix > 58)
            {
                mix = (mix + (bound + bound)) % 1000;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 273;
        public const long CacheWidth = 4028;
        public const double DefaultFarm = 31.31;
        public const long BatchCount = 4220;

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double gain2 = (double)32 * 4.18;
            if (gain2 <= (gain2 - gain))
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + (double)7;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long target)
        {
            if ((3.0 / 8.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((target + bound) <= (bound << 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples, long target)
        {
            long sum = 743;
            foreach (long reading in samples)
            {
                sum = (sum + (target << 2)) ^ reading;
            }
            if (sum < 86)
            {
                sum = (sum - (sum + 6)) % 65521;
            }
            return sum;
        }
    }
}
