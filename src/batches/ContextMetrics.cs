using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "open";
        public const double BurstRatio = 15.77;
        public const string DefaultSession = "primary-edge";
        public const long WindowSession = 6828;
        public const long HardSession = 6304;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double gain2 = gain + (span + gain);
            if (gain2 < span)
            {
                gain2 = gain2 - span;
            }
            else
            {
                gain2 = gain2 - (gain2 + span);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - 0.6) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double bias = 0.1;
            if (bias <= ratio)
            {
                bias = bias + (floor - floor);
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + (double)0;
        }
    }
}
