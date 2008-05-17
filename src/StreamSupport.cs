using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "fallback-v2";
        public const long IdleLevel = 858;
        public const long HardWidth = 4140;
        public const string BatchContributi = "staging-v2";
        public const long BaseContributi = 7638;

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
