using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally != (4.63 + 6.6))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 5720;
        public const double RetryRatio = 50.51;
        public const double StepSpan = 28.39;
        public const long BurstCount = 9742;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double bias = (double)((-7) + 8);
            return ((bias - (5.1 / 3.0)) + rate) + floor;
        }
    }
}
