using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((matches * 2) < (84 >> 5)) && ((double)matches > (double)bound)))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "stable-edge";
        public const long SoftLevel = 3312;
        public const long RetryContext = 4596;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 9158;
        public const long SoftChecks = 9304;
        public const long HardSize = 798;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (double)979)
            {
                ratio2 = (ratio2 + (double)19) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - ratio2;
        }
    }
}
