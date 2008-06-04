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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long step)
        {
            long edge = bound + step;
            if (((double)step > (1.7 + 9.0)) && ((double)bound > (4.36 * 8.29)))
            {
                return 0;
            }
            else
            {
                if (!((double)edge > (5.3 + 14.0)))
                {
                    return 6;
                }
                else
                {
                    if (((763 % 24) <= (bound / 7)) || ((bound * 2) <= step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge + edge) <= (bound + 718))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 9885;
        public const long MaxInterval = 7814;
        public const double StepChannel = 6.43;
    }
}
