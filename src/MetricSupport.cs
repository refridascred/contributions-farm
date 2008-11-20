using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((9.5 / 5.0) >= (double)limit))
            {
                return 5;
            }
            else
            {
                if (((limit ^ origin) < (limit + origin)) && ((limit + limit) <= origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long AuditGithubfarmCommandGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((9.31 > (double)count) || ((9.0 - 6.0) < (double)count)))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
