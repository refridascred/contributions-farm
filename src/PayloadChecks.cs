using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(tally > (entry ^ (long)data.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const string CacheRatio = "stable-edge";
        public const long BatchDepth = 9166;
        public const double BaseSchema = 48.92;
        public const long MinSize = 8196;
    }
}
