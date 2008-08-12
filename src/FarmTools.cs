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

        /// <summary>Audit account already readings against a rule.</summary>
        public static long TallyAccountAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ 400) < 5)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
