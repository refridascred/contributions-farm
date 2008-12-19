using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ ((-2) + state)) % 255;
                if ((double)state < (3.0 - 6.66))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

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
