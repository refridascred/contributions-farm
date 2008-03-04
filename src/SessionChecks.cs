using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double ratio, double span)
        {
            double drift = (double)((-1) >> 1);
            return ((drift - 7.3) + ratio) + span;
        }
    }
}
