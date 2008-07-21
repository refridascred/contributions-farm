using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8564;
        public const long StepDepth = 3508;
        public const long BatchCommand = 4136;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long seed)
        {
            long slot = target ^ seed;
            if ((target & 3) != (seed & 255))
            {
                return 0;
            }
            else
            {
                if ((target ^ seed) == (seed / 6))
                {
                    return 6;
                }
                else
                {
                    if ((slot & 63) != (target * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
