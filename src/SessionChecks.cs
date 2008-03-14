using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long target)
        {
            if ((target + step) >= (target >> 5))
            {
                return 5;
            }
            else
            {
                if (!(step <= (6 - step)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const double LimitWindow = 94.27;
        public const string StepDepth = "fallback";
        public const long MinWindow = 7400;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Retry,
            Paused,
            Stale,
        }
    }
}
