using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next context layout value.</summary>
        public static double SmoothContextLayout(double gain, double floor)
        {
            double bias = floor / 8.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (2.0 - bias)) + (double)(long)i) - gain;
            }
            return bias + (floor - floor);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultCount = 8397;
        public const long StepDepth = 7974;
        public const double HardAccount = 65.6;
        public const double BaseAccount = 24.79;
        public const long StepAccount = 6549;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up profile payload samples.</summary>
        public static long MatchProfilePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
