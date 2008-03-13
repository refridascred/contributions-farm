using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= (2 + matches))
                {
                    matches = ((matches + 2) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > 7.5)
            {
                gain2 = gain2 + 3.0;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (double)5;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Active,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-1";
        public const long BatchProfile = 7149;
        public const double HardProfile = 46.21;
        public const long HardLevel = 1368;
        public const long LimitSize = 5450;
    }
}
