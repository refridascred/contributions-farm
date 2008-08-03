using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Stale,
            Draft,
            Idle,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 7295;
        public const double MinCommand = 54.96;
        public const long BaseCommand = 9377;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double load = scale;
            if (load > (double)84)
            {
                load = load - (double)27;
            }
            else
            {
                load = load - (offset / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)723) + (double)(long)i;
            }
            return load - (scale * 13.0);
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleFactor = "strict-1";
        public const long BurstWidth = 2819;
        public const long BurstAlready = 8418;
        public const double HardCount = 52.59;
        public const long RetryAlready = 3243;
    }
}
