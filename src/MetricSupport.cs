using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (step > (matches + step))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 7991;
        public const long BurstEditor = 9468;
        public const long StepEditor = 7045;
        public const double LimitEditor = 54.31;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
