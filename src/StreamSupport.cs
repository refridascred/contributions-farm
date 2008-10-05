using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 2261;
        public const long IdleAlready = 4320;
        public const long CacheAlready = 5981;
        public const long DefaultAlready = 1388;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Dropped,
            Stale,
            Done,
            Locked,
        }
    }
}
