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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long delta = floor - step;
            if ((step * 2) < (delta % 24))
            {
                return 8;
            }
            else
            {
                if ((step << 3) >= ((-93) - floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= 2.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 2) > step) && ((floor >> 5) < delta))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
