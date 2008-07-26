using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine account cache values into a single score.</summary>
        public static long CombineAccountCache(long[] values, long seed)
        {
            long total = 14;
            foreach (long value in values)
            {
                total = ((total * 4) + (seed / 7)) % 101;
                if ((value & 3) == (value ^ value))
                {
                    total = (total + (total / 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinSpan = 23.48;
        public const long CacheTimeout = 5802;
        public const string WindowLevel = "latest-edge";

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
