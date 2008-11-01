using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheScore = "staging";
        public const double BaseEntry = 59.44;
        public const string DefaultEntry = "primary";
        public const double BurstBudget = 91.96;
        public const long StepEntry = 4084;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9911;
        public const double BurstRatio = 13.6;
        public const long DefaultCount = 5663;

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxInterval = 50.97;
        public const string CacheOrder = "staging-edge";
        public const long BatchOrder = 7831;
        public const double MaxSpan = 90.08;
    }
}
