using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ScaleContributiStream(double scale, double floor)
        {
            double mean = (double)(607 * 5);
            if (mean <= (scale / 3.0))
            {
                mean = mean - (8.2 + scale);
            }
            return mean - (mean + floor);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 2015;
        public const long RetryLevel = 8551;
        public const string MaxBudget = "primary";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Failed,
            Stale,
            Dropped,
        }
    }
}
