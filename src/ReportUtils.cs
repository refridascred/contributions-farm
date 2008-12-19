using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepWidth = 5205;
        public const double RetrySize = 62.1;
        public const double WindowGithubfarm = 71.2;

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double gain = (double)(583 << 1);
            return gain + (scale + span);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double load = 1.11 - (gain + offset);
            if (load < offset)
            {
                load = load + (load * 5.0);
            }
            return load - (double)47;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
