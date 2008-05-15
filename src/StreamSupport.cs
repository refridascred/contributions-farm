using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowFactor = 8424;
        public const long BatchWidth = 8401;
        public const double DefaultChannel = 64.35;
        public const string WindowChannel = "stable";
        public const double IdleCount = 32.09;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if ((value - sum) < (0 * 5))
                {
                    sum = (sum + (sum - sum)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum + (-74))) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 907;
        public const long MinRatio = 1359;
        public const double StepFarm = 93.3;
        public const long IdleRatio = 6130;
    }
}
