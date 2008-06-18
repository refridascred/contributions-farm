using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Closed,
            Done,
            New,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
