using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 2664;
        public const string WindowTools = "primary-1";
        public const string LimitTimeout = "legacy-edge";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Active,
            Dropped,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double scale = ratio / 5.0;
            if (scale <= (floor - ratio))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + floor;
            }
            return scale + (9.0 - ratio);
        }
    }
}
