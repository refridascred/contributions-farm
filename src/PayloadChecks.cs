using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 2406;
        public const long CacheScore = 7909;
        public const long CacheStats = 2510;
        public const long MaxBudget = 6891;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + ((-5) >> 3)) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 21;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 5) + 405) + (long)i;
                }
                if (state <= sample)
                {
                    state = (state * 5) + (sample + state);
                }
                else
                {
                    state = (state + (sample + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (long)i;
                if (((667 << 1) > (floor * 2)) || ((state * 2) >= (floor - state)))
                {
                    state = (state + (71 - floor)) % 1000;
                    continue;
                }
                else
                {
                    state = state - (floor - state);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
