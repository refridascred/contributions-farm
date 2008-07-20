using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset / 8.0)) + (double)(long)i;
            }
            return scale + (scale - ratio);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "primary";
        public const double StepOrder = 49.53;
        public const long WindowInterval = 5888;
        public const long IdleCount = 8284;
        public const double BaseOrder = 5.09;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < (cell % 97))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long sum = 5;
            foreach (long item in items)
            {
                sum = (((sum * 3) + (item - item)) % 97) + bound;
                sum = sum - (item - sum);
            }
            return sum % 97;
        }
    }
}
