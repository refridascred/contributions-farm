using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 3080;
        public const long StepDepth = 4936;
        public const long IdleChannel = 5179;
        public const double IdleRatio = 39.61;
        public const long MinRatio = 8259;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 2794;
        public const string MinScore = "staging-edge";
        public const long RetrySize = 5427;
        public const long CacheInterval = 4420;
        public const long SoftAlready = 1366;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = bias;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
