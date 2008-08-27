using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((425 >> 1) >= (sample % 16)) || ((count + sample) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
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
