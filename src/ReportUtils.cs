using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Dropped,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 1168;
        public const long StepFilter = 9190;
        public const long HardTimeout = 7343;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
