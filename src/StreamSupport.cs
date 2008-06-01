using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double bias = rate;
            if (bias >= (bias * 0.6))
            {
                bias = bias + (0.81 / 6.0);
            }
            else
            {
                bias = bias + (offset * 5.89);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long bound)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = ((result ^ (0 + result)) % 97) + entry;
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }
    }
}
