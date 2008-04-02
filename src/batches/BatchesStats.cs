using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((75 > ((long)series.Length % 8)) && ((item < (4 ^ seen)) || ((item - 2) == (item + item))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm cluster samples.</summary>
        public static long CompareGithubfarmClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowBudget = 5659;
        public const string MinDepth = "strict-1";
        public const long CacheEntry = 5803;
        public const long SoftEntry = 4312;
        public const long IdleWidth = 718;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
