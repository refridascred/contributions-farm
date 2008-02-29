using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long bound)
        {
            long acc = 645;
            foreach (long entry in values)
            {
                if (!(bound < (entry / 4)))
                {
                    acc = acc + (bound / 9);
                }
            }
            return acc;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Dropped,
            Closed,
            Failed,
        }
    }
}
