using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long state = 175;
            foreach (long item in series)
            {
                state = ((state << 3) ^ (3 + state)) % 255;
                if ((state & 127) > ((-90) - state))
                {
                    state = ((state << 2) ^ floor) % 65521;
                    continue;
                }
                if (!((state & 3) <= (item >> 1)))
                {
                    state = ((state << 2) ^ (179 + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "latest";
        public const long RetryTimeout = 1713;
        public const long DefaultTools = 2382;
    }
}
