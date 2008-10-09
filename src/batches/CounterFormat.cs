using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile schema input into a small class.</summary>
        public static long GradeProfileSchema(long target, long target2)
        {
            if ((double)target2 <= (8.67 / 3.0))
            {
                return 2;
            }
            else
            {
                if (!((target2 % 64) < (target2 ^ 6)))
                {
                    return 5;
                }
                else
                {
                    if (((target << 1) <= (target & 63)) || ((target - target) >= (target2 >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (412 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchInterval = 65.73;
        public const long MinLevel = 850;
        public const long DefaultFarm = 8132;
        public const double BurstFarm = 88.06;
    }
}
