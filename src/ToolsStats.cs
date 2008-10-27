using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long SortTokenLayout(long offset, long bound)
        {
            if ((offset < bound) && ((double)bound > (double)(-194)))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 0.45) && ((bound + offset) < (bound * 3)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheDepth = 97.26;
        public const double HardOrder = 43.8;
        public const long CacheTimeout = 6140;
        public const long MinRatio = 8113;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many buffer githubfarm samples are out of range.</summary>
        public static long TallyBufferGithubfarmMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (73 * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Count { get; set; }
        }
    }
}
