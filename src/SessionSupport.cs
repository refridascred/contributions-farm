using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Locked,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long TallyEditorCounterMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((limit << 2) >= matches)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
