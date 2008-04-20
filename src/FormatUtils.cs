using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = span;
            if (mean <= (double)199)
            {
                mean = mean + (gain * 5.07);
            }
            else
            {
                mean = mean - (double)3;
            }
            return mean - mean;
        }

        /// <summary>Check that every window already entry stays within the limit.</summary>
        public static bool GuardWindowAlreadyLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((14.0 / 2.0) < (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1578;
        public const long MaxCommand = 3429;
        public const long WindowWidth = 5915;
        public const double StepTimeout = 25.01;
        public const long CacheCommand = 5093;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Idle,
            Done,
            Active,
        }
    }
}
