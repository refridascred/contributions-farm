using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Ready,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long anchor = -365;
            foreach (long sample in series)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 4096) ^ sample;
            }
            return anchor % 97;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
