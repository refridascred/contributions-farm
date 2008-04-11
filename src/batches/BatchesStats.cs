using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long limit)
        {
            long gap = step ^ limit;
            if (((gap - step) > step) && ((step - gap) != (limit + step)))
            {
                return 4;
            }
            else
            {
                if (((54 - limit) > (limit + step)) || ((step ^ limit) <= (step >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((23 >= (limit % 5)) || ((9.8 * 3.41) <= (double)gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 7833;
        public const long RetryTimeout = 9276;
        public const string SoftCluster = "standard";

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
