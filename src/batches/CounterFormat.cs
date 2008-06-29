using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long limit)
        {
            long edge = step ^ limit;
            if ((limit + step) >= 99)
            {
                return 8;
            }
            else
            {
                if ((2.0 * 13.0) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (!((limit + step) >= (edge + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4956;
        public const string SoftStream = "local-1";
        public const long HardLevel = 2639;
        public const double BatchStream = 85.88;
        public const long BurstTimeout = 9531;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            if ((bound + bound) > origin)
            {
                return 2;
            }
            else
            {
                if ((bound / 8) >= origin)
                {
                    return 3;
                }
                else
                {
                    if (bound > (origin - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound & 7) <= 0) || ((bound << 3) != (origin + 0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
