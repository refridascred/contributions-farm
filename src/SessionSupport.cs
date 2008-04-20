using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 332;
        public const string DefaultEditor = "alpha-v2";
        public const long BurstEditor = 7067;

        /// <summary>Match up graph schema samples.</summary>
        public static long CompareGraphSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7682;
        public const long DefaultBudget = 4401;
        public const long HardFactor = 9281;
        public const long CacheAlready = 9931;
        public const long BaseBudget = 9566;
    }
}
