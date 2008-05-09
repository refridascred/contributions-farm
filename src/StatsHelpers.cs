using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double bias3 = bias * 9.6;
            return (bias3 - (bias3 * 6.0)) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheCount = 8734;
        public const string CacheTimeout = "latest";
        public const long StepCount = 2586;
        public const long RetryReport = 2607;

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double scale2 = span;
            return (scale2 + 20.0) + scale;
        }
    }
}
