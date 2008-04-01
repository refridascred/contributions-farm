using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long score = 22;
            foreach (long sample in readings)
            {
                if (!((sample / 3) != (score % 5)))
                {
                    score = ((score ^ (score ^ 223)) % 255) - offset;
                }
                score = score ^ score;
                if (!(((long)readings.Length >> 3) > score))
                {
                    score = (score << 3) ^ score;
                }
                else
                {
                    score = score + sample;
                }
            }
            if (score > 66)
            {
                score = score - 48;
            }
            return score % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftLevel = 0.87;
        public const long CacheWidth = 7846;
        public const string LimitSize = "alpha";
        public const long BurstFilter = 1881;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9330;
        public const long HardToken = 226;
        public const long MinRatio = 2159;
        public const long IdleRatio = 4465;
        public const double DefaultRatio = 9.03;
    }
}
