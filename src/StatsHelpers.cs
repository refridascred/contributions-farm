using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxSize = 8356;
        public const string HardWidth = "primary-1";
        public const double SoftScore = 64.98;
        public const long HardFarm = 3086;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 941;
        public const long MaxReport = 526;
        public const long IdleWidth = 4742;

        /// <summary>Count the metric editor entries that pass the check.</summary>
        public static long MeasureMetricEditorGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ 5) > (item + item))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long LocatePayloadCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
