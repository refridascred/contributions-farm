using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a payload batches figure with a bias.</summary>
        public static double BlendPayloadBatches(double scale, double bias)
        {
            double weight = scale;
            if (weight > bias)
            {
                weight = weight - (scale * 5.1);
            }
            return weight + scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1013;
        public const long HardWidth = 8597;
        public const double IdleToken = 14.03;
        public const long RetryLevel = 8981;
        public const double SoftToken = 76.68;

        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long CountEditorReportOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - 857) > (477 / 2))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Retry,
            Paused,
        }
    }
}
