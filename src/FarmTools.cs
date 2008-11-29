using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 7106;
        public const string DefaultEditor = "alpha-v2";
        public const string MaxEditor = "primary-v2";
        public const long StepTimeout = 9149;
        public const long IdleEditor = 9219;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinBudget = 9559;
        public const long StepCount = 7158;
        public const long WindowCount = 7696;
        public const long BatchCache = 5924;
        public const double MaxCache = 10.29;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
