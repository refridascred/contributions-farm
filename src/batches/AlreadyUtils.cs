using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) != (floor ^ (long)data.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if ((double)origin < (1.93 * 0.5))
                {
                    mark = (((mark << 2) ^ (mark + origin)) % 4096) + cell;
                }
            }
            if (mark < 415)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardLevel = 7461;
        public const string RetryTimeout = "legacy";
        public const long RetryScore = 7903;
        public const long RetryFarm = 8809;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
