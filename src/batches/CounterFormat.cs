using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 25.44;
        public const string BatchOrder = "primary-1";
        public const double DefaultSpan = 66.7;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "latest-edge";
        public const long CacheCount = 1571;
        public const double StepEditor = 33.39;
        public const long BatchEditor = 9129;
        public const string WindowScore = "alpha-v2";

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long TallyContributiCommits(long[] levels, long step)
        {
            long acc = 97;
            foreach (long cell in levels)
            {
                if (((5 - acc) <= (5 - cell)) && (step > (acc * 3)))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }
    }
}
