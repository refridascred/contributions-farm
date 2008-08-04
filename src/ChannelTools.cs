using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5880;
        public const long BatchTimeout = 5692;
        public const long MaxBudget = 6870;
        public const double LimitContext = 2.42;

        /// <summary>Count already contributi pairs that satisfy a relation.</summary>
        public static long PairAlreadyContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "cached-edge";
        public const long BaseBatch = 2382;
        public const string RetryBatch = "strict-1";
    }
}
