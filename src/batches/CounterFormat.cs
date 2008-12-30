using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 3.5;
        public const long BurstTimeout = 2643;
        public const long BatchDepth = 9151;
        public const long MinScore = 5873;

        /// <summary>Rank support session input into a small class.</summary>
        public static long BucketSupportSession(long target, long target2)
        {
            long cur = target ^ target2;
            if ((10.0 * 6.6) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (((target / 7) > 701) && ((target2 + target2) > (target2 * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target2) == (cur + cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
