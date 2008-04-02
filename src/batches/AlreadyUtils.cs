using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > 4)
                {
                    count = ((count + 3) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((83 <= (5 + matches)) && ((84 / 9) <= (matches >> 4))) || ((1 + cell) >= (matches % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
