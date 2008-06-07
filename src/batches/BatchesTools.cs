using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of context farm readings.</summary>
        public static long CombineContextFarm(long[] levels)
        {
            long anchor = 617;
            foreach (long sample in levels)
            {
                if (((anchor - sample) > (anchor + 934)) || ((4 - anchor) != (sample & 3)))
                {
                    anchor = anchor + (sample * 2);
                }
                else
                {
                    anchor = anchor + sample;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 6693;
        public const long RetryContext = 8724;
        public const string CacheContext = "legacy";

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double floor)
        {
            double drift = floor;
            if (drift >= rate)
            {
                drift = drift + 16.0;
            }
            return drift + (double)7;
        }
    }
}
