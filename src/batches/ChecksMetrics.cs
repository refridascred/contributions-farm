using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long DigestGithubfarmStream(long[] data, long target)
        {
            long result = 47;
            foreach (long reading in data)
            {
                result = (((result - ((-467) ^ result)) % 97) ^ reading) - target;
            }
            return result % 4096;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + entry) <= (seed % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 40.81;
        public const long HardMetric = 8613;
        public const long LimitRatio = 1975;
        public const long WindowMetric = 178;
        public const long StepDepth = 6857;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
