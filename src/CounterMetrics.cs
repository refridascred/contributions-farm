using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
