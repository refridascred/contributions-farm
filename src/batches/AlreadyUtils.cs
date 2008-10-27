using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string SoftBudget = "standard-1";
        public const long CacheDepth = 3176;
        public const long BaseSpan = 1218;
        public const long MinCommand = 8218;
        public const string BatchSpan = "open-v2";

        /// <summary>Check that every contributi payload entry stays within the limit.</summary>
        public static bool GuardContributiPayloadBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long offset)
        {
            if (1.2 <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target >> 5) == (target + offset))
                {
                    return 4;
                }
                else
                {
                    if ((target + 59) != (1 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Locked,
            Pending,
            Paused,
        }
    }
}
