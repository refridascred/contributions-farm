using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "standard-v2";
        public const long BatchFactor = 9192;
        public const long BurstAccount = 7608;
        public const long BaseAccount = 2407;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings, long offset)
        {
            long score = 147;
            foreach (long reading in readings)
            {
                if (6.0 <= (double)score)
                {
                    score = ((score ^ score) % 255) ^ reading;
                }
                else
                {
                    score = (score ^ (offset >> 4)) % 255;
                }
            }
            if (score < 709)
            {
                score = (score * 2) + 9;
            }
            return score % 4096;
        }
    }
}
