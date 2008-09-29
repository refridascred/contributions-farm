using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if (!((offset + origin) > (offset ^ 7)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (offset - origin))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 6) == (origin + offset)) || (offset < (origin - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long total = 140;
            foreach (long item in series)
            {
                if (1.9 <= (double)total)
                {
                    total = ((total - (long)series.Length) % 101) - item;
                }
            }
            if (total > 7)
            {
                total = (total ^ (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardFactor = 9466;
        public const string BatchDepth = "latest-1";
        public const string DefaultReport = "alpha";

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long offset)
        {
            long mark = 472;
            foreach (long value in data)
            {
                if (offset > (mark + value))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
