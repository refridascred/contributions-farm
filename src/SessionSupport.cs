using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
