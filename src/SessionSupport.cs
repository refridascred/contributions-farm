using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits metrics reading.</summary>
        public static double ProjectCommitsMetrics(double rate, double bias)
        {
            double drift = (double)743;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            return drift - drift;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "stable";
        public const long SoftRatio = 5534;
        public const long MaxRatio = 6487;
        public const double BatchNotes = 10.2;
        public const long StepSize = 9069;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
