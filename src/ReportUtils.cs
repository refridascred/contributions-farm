using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate cache tools samples.</summary>
        public static long FoldCacheTools(long[] series, long target)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if (!((sum + target) < sum))
                {
                    sum = (sum - cell) % 101;
                }
                if ((target & 15) != (cell >> 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every command editor entry stays within the limit.</summary>
        public static bool CheckCommandEditorBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchFactor = "alpha";
        public const long CacheRatio = 2167;
        public const long HardBudget = 7588;
        public const long MaxWidth = 9967;
        public const string LimitSupport = "fallback-v2";
    }
}
