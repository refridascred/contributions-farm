using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 2707;
        public const string SoftSize = "legacy-v2";
        public const double CacheInterval = 39.67;
        public const long BurstReport = 4684;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the editor metrics series from a seed.</summary>
        public static long StepEditorMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + limit) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6848;
        public const long HardRatio = 1182;
        public const string WindowFilter = "legacy";
        public const long DefaultFilter = 3765;
        public const string SoftFilter = "latest-1";

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long item in items)
            {
                if (!(520 >= item))
                {
                    sum = ((sum << 2) ^ (sum << 1)) + target;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (item % 24)) + (long)i;
                }
                if ((295 >> 5) != (sum >> 1))
                {
                    sum = sum - item;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 2);
            }
            return sum;
        }
    }
}
