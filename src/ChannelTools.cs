using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long TallyStatsTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 5) >= 199))
                {
                    tally = ((tally + 1) ^ datum) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
