using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseRatio = "stable";
        public const double BaseEditor = 81.72;
        public const long CacheSize = 5069;
        public const long BatchScore = 9809;
        public const double SoftWidth = 51.85;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = (((carry << 2) ^ (seed + carry)) % 255) ^ entry;
            }
            return carry;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of batches tools readings.</summary>
        public static long CompareBatchesToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            long diff = floor + floor2;
            if ((diff << 1) >= (floor << 2))
            {
                return 2;
            }
            else
            {
                if (258 >= (diff + 4))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 / 9) >= (floor2 ^ diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < diff))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
