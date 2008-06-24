using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 4830;
        public const double RetryInterval = 95.98;
        public const long MaxNotes = 3322;
        public const long RetryNotes = 3771;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 + 1.0) + bias;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
