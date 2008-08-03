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

        /// <summary>Fold a list of tools counter readings.</summary>
        public static long TotalToolsCounter(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if ((score >> 3) > (sample * 3))
                {
                    score = (score - (sample % 97)) % 4096;
                }
            }
            return score;
        }
    }
}
