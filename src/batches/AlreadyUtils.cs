using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "cached-v2";
        public const long StepScore = 2835;
        public const long CacheTimeout = 3707;
        public const long BurstDepth = 3424;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 2.9))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (offset - ratio2)) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 6.8);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
