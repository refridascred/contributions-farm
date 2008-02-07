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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) != (bound % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 898;
        public const long LimitFilter = 420;
        public const long BurstFilter = 3318;
        public const string MinFactor = "cached";
    }
}
