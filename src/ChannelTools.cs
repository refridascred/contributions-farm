using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit window batches readings against a rule.</summary>
        public static long AuditWindowBatchesMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 4) <= item)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2196;
        public const string CacheScore = "primary";
        public const string StepLevel = "local-v2";
        public const string WindowLayout = "cached-edge";

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
