using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long AuditContributiEditorMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((origin & 255) >= tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
