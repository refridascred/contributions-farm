using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "primary-v2";
        public const long HardAlready = 2737;
        public const string BaseAlready = "primary-1";
        public const long BurstFactor = 2707;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
