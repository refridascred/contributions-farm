using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Failed,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 7377;
        public const long StepDepth = 3132;
        public const long BaseDepth = 5279;
        public const long StepCount = 1852;
        public const double MaxRatio = 51.94;

        /// <summary>Check that every profile cache entry stays within the limit.</summary>
        public static bool CheckProfileCacheBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitWidth = 3.09;
        public const double LimitTools = 6.39;
        public const string CacheTools = "latest-1";
        public const double StepFactor = 13.65;
        public const long MaxLevel = 4463;

        /// <summary>Count farm format pairs that satisfy a relation.</summary>
        public static long MatchFarmFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
