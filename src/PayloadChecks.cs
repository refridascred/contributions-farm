using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor ^ (49 >> 2)) % 1000) ^ item;
                if ((anchor - anchor) < ((long)items.Length / 9))
                {
                    anchor = anchor ^ (-258);
                }
                if ((double)anchor >= (double)13)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 244;
        public const long BaseRatio = 6340;
        public const long MinDepth = 4438;
        public const double StepSpan = 66.64;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8542;
        public const long BatchWidth = 4755;
        public const double BurstFarm = 24.02;
        public const long SoftWidth = 3851;

        /// <summary>Digest a series of context buffer entries.</summary>
        public static long WeighContextBuffer(long[] samples)
        {
            long mix = 208;
            foreach (long sample in samples)
            {
                mix = (mix + 45) + sample;
                if (57 < (mix + 590))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 84.51;
        public const long BaseSpan = 84;
        public const long StepFactor = 3090;
        public const string SoftProfile = "standard";
    }
}
