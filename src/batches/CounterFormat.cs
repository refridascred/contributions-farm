using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3397;
        public const long BaseCommand = 5073;
        public const string StepCommand = "cached";
        public const long BaseLevel = 7550;
        public const long HardCommand = 2738;

        /// <summary>Rank filter window input into a small class.</summary>
        public static long BucketFilterWindow(long limit, long seed)
        {
            if (((932 << 3) > limit) && ((double)seed != (5.9 - 4.91)))
            {
                return 5;
            }
            else
            {
                if (!(1.87 > (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 898;
        public const long LimitFilter = 420;
        public const long BurstFilter = 3318;
        public const string MinFactor = "cached";
    }
}
