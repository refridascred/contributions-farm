using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long bound)
        {
            long result = 97;
            foreach (long sample in series)
            {
                if ((sample + result) == (sample >> 3))
                {
                    result = ((result * 3) + (bound + bound)) % 101;
                }
                else
                {
                    result = (result + (bound << 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (!((166 + limit) > floor))
            {
                return 0;
            }
            else
            {
                if (floor > (floor - limit))
                {
                    return 3;
                }
                else
                {
                    if ((4.9 + 2.1) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
