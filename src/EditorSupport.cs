using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Dropped,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8786;
        public const string StepScore = "cached";
        public const long RetryCount = 8246;
        public const string MaxEditor = "legacy-edge";
        public const long IdleRatio = 9311;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-274) << 1) > (item >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 1066;
        public const double DefaultCount = 38.94;
        public const double RetryBatch = 60.83;
        public const long BaseBudget = 6850;
        public const long CacheSize = 4872;
    }
}
