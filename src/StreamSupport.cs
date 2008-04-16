using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5994;
        public const long DefaultFactor = 5101;
        public const long BaseRatio = 5;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long state = 883;
            foreach (long reading in data)
            {
                if ((reading / 9) != (state ^ seed))
                {
                    state = state + (seed * 2);
                }
            }
            return state;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Ready,
            Synced,
            Idle,
        }
    }
}
