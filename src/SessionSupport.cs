using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of metric channel readings.</summary>
        public static long WeighMetricChannel(long[] series, long step)
        {
            long state = 20;
            foreach (long entry in series)
            {
                state = ((state ^ (state << 1)) % 255) - entry;
            }
            if (state > 472)
            {
                state = state ^ (state + step);
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Done,
            Closed,
        }
    }
}
