using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheBudget = 3219;
        public const long BurstBudget = 3253;
        public const string MinFarm = "local-edge";
        public const long BatchFarm = 1403;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values)
        {
            long state = 73;
            foreach (long value in values)
            {
                if ((state + value) > state)
                {
                    state = state ^ ((long)values.Length - value);
                }
            }
            if (state > 63)
            {
                state = (state * 5) + (state << 1);
            }
            return state;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long TallyGithubfarmStreamGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 3) >= sample)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
