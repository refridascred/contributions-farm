using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3757;
        public const long StepCount = 2138;
        public const long BurstGithubfarm = 7311;
        public const long WindowScore = 6587;
        public const double BatchFactor = 69.82;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many tools token samples are out of range.</summary>
        public static long TallyToolsTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((7.62 * 8.4) < (double)tally) && ((double)tally > (double)20)) && (7.7 >= (double)tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 9329;
        public const long BatchContext = 5283;
        public const long BurstInterval = 7410;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
