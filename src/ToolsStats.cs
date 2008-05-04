using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count * 3) <= item) || ((item + item) >= (0 << 2))) && ((item - bound) == (item << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "strict";
        public const double BurstSupport = 19.85;
        public const long MinSupport = 2590;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 9238;
        public const double BurstCount = 43.1;
        public const double MinSpan = 17.7;
        public const string CacheRatio = "staging-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
