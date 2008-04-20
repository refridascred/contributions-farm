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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = mark - (origin * 5);
                mark = mark + (mark * 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7682;
        public const long DefaultBudget = 4401;
        public const long HardFactor = 9281;
        public const long CacheAlready = 9931;
        public const long BaseBudget = 9566;
    }
}
