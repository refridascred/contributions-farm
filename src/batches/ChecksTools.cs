using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long PairCommitsBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ result;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 63.58;
        public const double HardLevel = 30.72;
        public const long SoftLevel = 4760;
        public const long MinScore = 1081;
        public const long RetryLevel = 9238;
    }
}
