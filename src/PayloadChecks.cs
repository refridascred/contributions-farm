using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (target - target))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const string CacheRatio = "stable-edge";
        public const long BatchDepth = 9166;
        public const double BaseSchema = 48.92;
        public const long MinSize = 8196;
    }
}
