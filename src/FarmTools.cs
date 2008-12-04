using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 2900;
        public const double BurstEditor = 59.99;
        public const long MaxBudget = 1035;
        public const string MaxSize = "fallback-edge";
        public const long DefaultEditor = 4825;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 989;
            foreach (long entry in levels)
            {
                score = (score + 69) % 65521;
                if (((double)entry >= (20.0 * 2.51)) && ((score + entry) > entry))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
