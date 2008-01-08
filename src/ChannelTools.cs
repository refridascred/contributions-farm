using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 537;
            foreach (long value in levels)
            {
                state = state + (value - value);
                state = (state + state) % 65521;
            }
            if (state > 334)
            {
                state = ((state << 3) ^ (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Paused,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
