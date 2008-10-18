using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 3192;
        public const string RetryRecord = "local-edge";
        public const long DefaultRecord = 9869;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long state = 369;
            foreach (long cell in series)
            {
                if ((double)cell == (20.0 + 0.4))
                {
                    state = (state - cell) % 4096;
                }
            }
            if (state > 594)
            {
                state = ((state * 3) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
