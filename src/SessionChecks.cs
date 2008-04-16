using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 2868;
        public const string WindowProfile = "local";
        public const long DefaultWidth = 1680;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double mean = (bias / 6.0) * 8.36;
            if (mean >= (mean / 5.0))
            {
                mean = mean + span;
            }
            return mean - (double)5;
        }
    }
}
