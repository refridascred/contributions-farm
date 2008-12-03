using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first command token entry that matches the target.</summary>
        public static long LookupCommandTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long step)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    score = (score - (score - entry)) % 1000;
                }
                else
                {
                    score = (score * 4) + entry;
                }
            }
            if (score < 71)
            {
                score = (score + (step >> 1)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 595;
        public const long IdleMetric = 8261;
        public const long HardMetric = 8249;
        public const string MinDepth = "strict-v2";
    }
}
