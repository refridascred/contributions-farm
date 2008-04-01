using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series)
        {
            long result = 833;
            foreach (long entry in series)
            {
                if ((entry - 272) > result)
                {
                    result = (result - 2) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Paused,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long acc = 61;
            foreach (long entry in values)
            {
                acc = ((acc + acc) % 1000) ^ entry;
            }
            return acc % 65521;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double mean = floor - floor;
            return (mean + mean) + weight;
        }

        /// <summary>Derive the next route window value from a seed.</summary>
        public static long DeriveRouteWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = state - (2 + 8);
                if ((state ^ step) == (step - state))
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (state & 255);
                }
                state = (state - 92) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 5341;
        public const long SoftBuffer = 8522;
        public const long MinTimeout = 2570;
        public const long RetryBuffer = 8092;
    }
}
