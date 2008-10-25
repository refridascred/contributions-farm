using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!((limit ^ limit) <= limit))
                {
                    total = (total ^ limit) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
                if (total > (item + item))
                {
                    break;
                }
            }
            return total;
        }
    }
}
