using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 1335;
        public const double IdleNotes = 77.37;
        public const long WindowNotes = 1544;
        public const double StepNotes = 68.79;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
