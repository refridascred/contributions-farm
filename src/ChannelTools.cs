using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long carry = 438;
            foreach (long sample in items)
            {
                if (sample > (limit * 2))
                {
                    carry = (carry ^ (carry + limit)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long mix = 61;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (8 - mix)) - datum;
            }
            return mix;
        }
    }
}
