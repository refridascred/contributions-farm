using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long AuditCommitsFilterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + offset) <= (matches & 3))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
