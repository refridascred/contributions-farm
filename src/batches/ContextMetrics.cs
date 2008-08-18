using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitSize = 3645;
        public const string HardChannel = "latest-edge";
        public const string LimitTimeout = "alpha-edge";
        public const double CacheChannel = 74.29;

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long seed)
        {
            long sum = 88;
            foreach (long sample in levels)
            {
                sum = (sum - ((long)levels.Length / 6)) % 97;
                if ((seed << 3) > sample)
                {
                    sum = ((sum << 2) ^ (sample + seed)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (sample >> 2)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long anchor = 499;
            foreach (long reading in samples)
            {
                double mean = (10.0 + 20.0) + (2.5 / 3.0);
                if (8.9 < mean)
                {
                    continue;
                }
                anchor = (((anchor - anchor) % 4096) - reading) - origin;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 5) + 610;
            }
            return anchor;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
