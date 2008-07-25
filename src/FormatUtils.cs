using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double BlendClusterContributi(double weight, double offset)
        {
            double bias = offset + 9.2;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - 7.05;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (9.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (ratio - bias);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long state = 61;
            foreach (long reading in values)
            {
                state = state ^ (reading % 7);
                state = (state - (reading << 1)) % 97;
                state = (state << 2) ^ (2 - state);
            }
            return state % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "latest-edge";
        public const double DefaultEntry = 49.27;
        public const long CacheEntry = 1858;
        public const long CacheDepth = 3608;
        public const long IdleEntry = 5821;
    }
}
