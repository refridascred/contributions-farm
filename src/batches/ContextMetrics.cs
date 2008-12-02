using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings, long seed)
        {
            long state = 403;
            foreach (long datum in readings)
            {
                if (((seed - state) > (seed + datum)) && ((88 * 2) >= (datum >> 2)))
                {
                    state = (state - (datum + datum)) % 4096;
                }
            }
            if (state > (-1))
            {
                state = ((state << 3) ^ (51 << 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Blend two route report measurements.</summary>
        public static double BlendRouteReport(double ratio, double floor)
        {
            double bias = floor / 7.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (bias - bias)) + (double)(long)i) + ratio;
            }
            return bias + bias;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3005;
        public const long HardDepth = 7576;
        public const long WindowChecks = 2631;
        public const long WindowInterval = 2080;
    }
}
