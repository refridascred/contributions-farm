using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up contributi checks samples.</summary>
        public static long OverlapContributiChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "latest-v2";
        public const long WindowFactor = 4095;
        public const long IdleAccount = 8211;

        /// <summary>Project the next stats token value.</summary>
        public static double ScaleStatsToken(double rate, double bias)
        {
            double scale = 3.5;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) - (double)(long)i) - rate;
            }
            return scale - 3.64;
        }
    }
}
