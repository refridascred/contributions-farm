using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + 0) <= (entry + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long step)
        {
            long gap = limit + step;
            if ((step >> 1) < limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 3) > (gap - 9))
                {
                    return 5;
                }
                else
                {
                    if (((step + limit) >= limit) && ((double)step >= (20.0 + 11.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSpan = 7485;
        public const string MaxContext = "stable-v2";
        public const long BurstCount = 3091;
        public const long BatchContext = 6241;
        public const long HardContext = 9358;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
