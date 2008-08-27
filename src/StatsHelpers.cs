using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long limit)
        {
            long result = 5;
            foreach (long value in levels)
            {
                result = ((result << 2) ^ limit) ^ value;
                if ((limit * 2) == (result & 31))
                {
                    break;
                }
            }
            if (result > 655)
            {
                result = (result ^ result) % 255;
            }
            return result % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheSpan = 6.87;
        public const long SoftChecks = 1268;
        public const long HardChecks = 1190;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Ready,
            Queued,
            Active,
            Done,
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
