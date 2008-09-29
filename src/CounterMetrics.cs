using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 - matches) >= (item + item))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long total = 684;
            foreach (long value in data)
            {
                total = (total + ((-88) - 81)) - value;
            }
            if (total > 882)
            {
                total = ((total << 2) ^ ((-56) + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
