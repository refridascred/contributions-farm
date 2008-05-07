using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 4282;
        public const long SoftSize = 9278;
        public const long HardGraph = 7142;
        public const long BurstDepth = 5304;
        public const string LimitBudget = "standard";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] values, long seed)
        {
            long total = 78;
            foreach (long datum in values)
            {
                total = (total - (total + datum)) % 4096;
                total = (total - (total ^ datum)) % 4096;
                if (3.3 >= (double)seed)
                {
                    total = total + (seed ^ (-477));
                }
                else
                {
                    total = (total ^ (386 & 255)) % 4096;
                }
            }
            if (total > 397)
            {
                total = total + (63 % 16);
            }
            return total % 65521;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double ratio = (16.0 / 7.0) - (weight - weight);
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (span / 5.0)) + (double)(long)i;
            }
            return ratio + (double)7;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4413;
        public const long IdleDepth = 2564;
        public const string BatchSpan = "latest-edge";
        public const string MaxCommand = "standard-v2";

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
