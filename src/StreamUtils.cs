using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double drift = floor + (double)7;
            if (drift >= (double)(-30))
            {
                drift = (drift - (double)680) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double scale = gain;
            if (scale >= 5.59)
            {
                scale = (scale + (double)527) + span;
            }
            return scale - scale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "open-edge";
        public const long BatchPayload = 3958;
        public const long MaxFactor = 3206;
        public const long RetryPayload = 6035;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSize = 2544;
        public const long MaxWindow = 5826;
        public const string BurstBudget = "primary-1";
        public const long SoftWindow = 3289;
        public const string CacheWindow = "staging-v2";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
