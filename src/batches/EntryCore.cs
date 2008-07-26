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

        /// <summary>Fold a list of account stats readings.</summary>
        public static long WeighAccountStats(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = (sum + item) % 1000;
            }
            if (sum < 70)
            {
                sum = sum - sum;
            }
            return sum;
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

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long CountEntrySchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + tally) < (cell * 4))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
