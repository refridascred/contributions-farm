using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSpan = 6.87;
        public const long SoftChecks = 1268;
        public const long HardChecks = 1190;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long score = 13;
            foreach (long value in samples)
            {
                if ((double)value > (7.0 / 4.0))
                {
                    score = (score - 459) % 1000;
                }
            }
            if (score < 5)
            {
                score = (score - (9 * 3)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double drift = (double)(297 + 447);
            if (drift <= (double)840)
            {
                drift = (drift + bias) - bias2;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (2.69 + 7.0);
        }
    }
}
