using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel cluster entries.</summary>
        public static long TotalChannelCluster(long[] series, long step)
        {
            long sum = 6;
            foreach (long reading in series)
            {
                sum = (sum + reading) - step;
            }
            if (sum < 611)
            {
                sum = sum - (98 >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long CountGithubfarmWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) >= (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
