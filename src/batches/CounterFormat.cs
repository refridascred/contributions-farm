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

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long score = 9;
            foreach (long datum in values)
            {
                score = ((score + (8 + score)) % 101) ^ datum;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 898;
        public const long LimitFilter = 420;
        public const long BurstFilter = 3318;
        public const string MinFactor = "cached";
    }
}
