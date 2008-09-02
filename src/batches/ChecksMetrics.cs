using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph context samples.</summary>
        public static long CombineGraphContext(long[] items, long bound)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor - (entry << 1)) + bound;
            }
            return anchor;
        }

        /// <summary>Fold a list of already command readings.</summary>
        public static long TotalAlreadyCommand(long[] values)
        {
            long total = 14;
            foreach (long value in values)
            {
                if (((total + value) >= (5 % 100)) || ((value << 3) > total))
                {
                    total = (total ^ (528 - value)) % 97;
                }
            }
            if (total < 327)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 96.24;
        public const double WindowChannel = 69.34;
        public const long SoftChannel = 3318;
        public const long DefaultDepth = 1660;
        public const long CacheInterval = 346;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
