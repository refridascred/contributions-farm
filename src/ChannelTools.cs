using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Idle,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Ready,
            Stale,
        }
    }
}
