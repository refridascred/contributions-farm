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

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long floor)
        {
            long prev = target ^ floor;
            if ((target / 2) >= prev)
            {
                return 1;
            }
            else
            {
                if ((prev >= (floor - floor)) || (prev < (floor - target)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
