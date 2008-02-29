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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item & 1) == (9 % 97))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
