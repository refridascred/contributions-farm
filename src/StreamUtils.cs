using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 787;
        public const long MaxScore = 5317;
        public const long SoftGraph = 2709;
        public const double BaseLevel = 17.74;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (2.6 / 4.0))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double mean = (bias + floor) / 3.0;
            return mean - floor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinWidth = "stable";
        public const long StepCount = 3785;
        public const long HardContributi = 4747;
        public const long DefaultScore = 2927;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3040;
        public const string BurstLevel = "fallback-1";
        public const long MinBuffer = 4555;
    }
}
