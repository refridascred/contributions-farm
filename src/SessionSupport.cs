using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Retry,
            Pending,
            Done,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
