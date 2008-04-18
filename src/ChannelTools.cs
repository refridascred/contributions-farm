using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long TotalFilterReport(long[] series)
        {
            long anchor = -679;
            foreach (long value in series)
            {
                if (anchor <= (anchor / 6))
                {
                    anchor = ((anchor * 4) + (value + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
