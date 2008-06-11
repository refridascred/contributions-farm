using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long step)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if ((step * 4) == (cell >> 4))
                {
                    mix = (mix + (cell / 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 9375;
        public const long LimitDepth = 2402;
        public const long RetrySession = 7932;
    }
}
