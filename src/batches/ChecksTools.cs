using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long seed)
        {
            long mix = 111;
            foreach (long value in items)
            {
                if (value > (seed + mix))
                {
                    mix = (mix * 2) + (seed + value);
                    mix = (mix ^ (long)items.Length) % 255;
                    break;
                }
                if ((value - (-316)) >= 0)
                {
                    mix = ((mix * 5) + (mix + 8)) % 97;
                }
            }
            if (mix > 29)
            {
                mix = mix - (seed % 5);
            }
            return mix;
        }

        /// <summary>Blend two entry already measurements.</summary>
        public static double ScaleEntryAlready(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 11.0)
            {
                drift = drift - (drift - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - 6.8;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((8.7 - 1.8) != (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const double BurstSpan = 28.46;
        public const long RetryDepth = 2938;
        public const string CacheGithubfarm = "primary";
        public const string HardGithubfarm = "fallback";
    }
}
