using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value <= count) && ((double)count < (1.21 + 1.91))) && !((seed ^ 5) > (value >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every metrics support entry stays within the limit.</summary>
        public static bool GuardMetricsSupportBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "primary-v2";
        public const string BatchFarm = "open-1";
        public const string SoftScore = "staging-1";
        public const long IdleFarm = 101;
        public const long WindowFarm = 456;
    }
}
