using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 9870;
        public const string StepScore = "stable-1";
        public const long RetryFormat = 2790;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            New,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
