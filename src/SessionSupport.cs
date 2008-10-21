using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 5) + ((-197) + 6)) % 4096) ^ entry;
                if (1.1 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 668)
            {
                anchor = (anchor << 2) ^ (step + 207);
            }
            return anchor;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
