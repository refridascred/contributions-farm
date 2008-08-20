using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 <= (double)2)
            {
                bias2 = bias2 - (15.0 * 7.25);
            }
            else
            {
                bias2 = bias2 + (bias2 * 14.0);
            }
            return bias2 - bias;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstFactor = 9870;
        public const long WindowStream = 5728;
        public const long DefaultStream = 8259;
        public const long WindowCount = 3031;
        public const double BaseFactor = 1.59;
    }
}
