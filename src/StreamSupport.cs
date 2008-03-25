using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long TallyEditorMetricsGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4.0 - 4.63) == (double)value)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((double)limit >= 5.34) && ((0.1 * 8.49) != (double)state))
                {
                    state = ((state << 2) ^ (670 << 2)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 9336;
        public const long BurstRecord = 3214;
        public const double WindowRatio = 6.81;
        public const string BatchLevel = "strict-1";
        public const long LimitScore = 1240;
    }
}
