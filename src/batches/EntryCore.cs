using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long TotalSchemaCluster(long[] levels)
        {
            long sum = -7;
            foreach (long item in levels)
            {
                sum = ((sum * 5) + (sum & 1)) ^ item;
                sum = ((sum * 5) + (-92)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 9762;
        public const long DefaultScore = 4370;
        public const double SoftCommits = 7.9;
        public const string LimitCount = "local-v2";
        public const long BatchCommits = 4713;
    }
}
