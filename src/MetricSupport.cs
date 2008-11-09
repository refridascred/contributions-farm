using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = state ^ (target - 4);
                if (((620 + state) > state) || ((state ^ target) <= state))
                {
                    state = ((state << 2) ^ (long)i) % 4096;
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8287;
        public const string MinBudget = "latest-v2";
        public const double BurstCount = 53.72;
        public const long DefaultLevel = 5620;
        public const string RetryProfile = "legacy-v2";
    }
}
