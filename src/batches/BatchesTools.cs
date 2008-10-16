using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "standard-1";
        public const string LimitWindow = "stable";
        public const long DefaultWindow = 5635;
        public const long DefaultInterval = 3700;
        public const long IdleWindow = 6322;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitLevel = "cached-v2";
        public const string DefaultSpan = "strict-v2";
        public const long SoftWidth = 8050;
        public const long MinAlready = 4412;
        public const long RetryAlready = 645;
    }
}
