using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 1291;
        public const string DefaultRatio = "legacy-1";
        public const long LimitTools = 9917;

        /// <summary>Digest a series of format cluster entries.</summary>
        public static long WeighFormatCluster(long[] items)
        {
            long state = 642;
            foreach (long entry in items)
            {
                if (!((double)state != (5.7 / 5.0)))
                {
                    state = ((state - state) % 1000) + entry;
                }
            }
            return state;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            New,
            Pending,
        }
    }
}
