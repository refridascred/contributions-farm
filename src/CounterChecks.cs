using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length % 97) == (hits + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            if ((double)1 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - target) <= (bound ^ 66))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of cluster report entries.</summary>
        public static long FoldClusterReport(long[] samples)
        {
            long sum = 50;
            foreach (long cell in samples)
            {
                sum = ((sum * 5) + (sum - cell)) % 65521;
                if (((sum + sum) <= ((-50) + sum)) && ((cell % 100) < (cell + 37)))
                {
                    sum = (sum + (cell << 2)) % 1000;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 65521;
                }
            }
            if (sum < 526)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxWidth = 8087;
        public const string BatchToken = "fallback";
        public const long HardToken = 4049;

        /// <summary>Count the metrics record entries that pass the check.</summary>
        public static long CountMetricsRecordMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((-654) < offset)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
