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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 0.4)
                {
                    count = count + 2;
                }
            }
            return count;
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
