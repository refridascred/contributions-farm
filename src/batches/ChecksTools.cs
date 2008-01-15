using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
