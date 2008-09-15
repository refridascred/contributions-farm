using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series)
        {
            long sum = -848;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum + entry);
                if (((622 - sum) > 483) && ((sum % 8) >= entry))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 5428;
        public const string StepStream = "strict";
        public const string WindowRatio = "open-v2";
        public const long BurstSize = 4432;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
