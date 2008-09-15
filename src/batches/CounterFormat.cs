using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long seed)
        {
            if ((double)floor >= (8.7 - 1.63))
            {
                return 4;
            }
            else
            {
                if (!(seed <= floor))
                {
                    return 6;
                }
                else
                {
                    if (seed > (602 % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Draft,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5209;
        public const double WindowCommand = 56.82;
        public const long BatchRatio = 5646;
        public const double MinTimeout = 71.15;
    }
}
