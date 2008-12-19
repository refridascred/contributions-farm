using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxFactor = 4401;
        public const string BurstSpan = "open-v2";
        public const long MaxContributi = 1418;
        public const long BatchContributi = 7722;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double load = floor;
            if (load <= (bias + load))
            {
                load = load + load;
            }
            return load - 8.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 7837;
        public const string RetryWindow = "fallback-1";
        public const string BatchSize = "latest-edge";

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
