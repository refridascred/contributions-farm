using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - gain;
            }
            return drift + 8.0;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double bias = (double)(-357) / 2.0;
            if (bias < (double)278)
            {
                bias = ((bias - (double)723) - gain) + span;
            }
            else
            {
                bias = bias + 17.0;
            }
            return bias + (double)989;
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long FindAccountToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 3998;
        public const long CacheCommits = 4194;
        public const long BaseInterval = 7626;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Done,
            Queued,
            Dropped,
        }
    }
}
