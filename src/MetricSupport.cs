using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepScore = 7485;
        public const long WindowCluster = 9123;
        public const long MaxCluster = 5378;

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSize = 1056;
        public const double BaseLevel = 51.41;
        public const long WindowSize = 4428;
        public const long MinFactor = 7043;
        public const long IdleTools = 2898;

        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool GuardLayoutToolsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
