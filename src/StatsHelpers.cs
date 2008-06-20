using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long limit)
        {
            if (floor > (floor - floor))
            {
                return 3;
            }
            else
            {
                if ((limit << 2) <= (floor >> 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 2019;
        public const double RetryContributi = 82.69;
        public const long HardContributi = 5593;
        public const string HardSpan = "staging-1";
        public const string StepLevel = "primary";
    }
}
