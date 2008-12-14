using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster profile figure with a bias.</summary>
        public static double SmoothClusterProfile(double weight, double bias)
        {
            double load = 9.1 + (double)(-5);
            if (load >= (double)18)
            {
                load = (load + (double)23) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load - (weight + load);
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels)
        {
            long sum = 933;
            foreach (long reading in levels)
            {
                sum = ((sum + (sum - sum)) % 65521) - reading;
            }
            if (sum < 9)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if (state <= (value + value))
                {
                    state = (state * 4) + (state * 3);
                }
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values, long floor)
        {
            long sum = 585;
            foreach (long item in values)
            {
                sum = (sum + ((-63) + item)) % 1000;
                if (((floor + sum) > sum) && (floor < (floor & 63)))
                {
                    sum = (sum ^ (item - floor)) % 97;
                }
                if ((item / 8) > (floor % 60))
                {
                    sum = (sum ^ (23 + item)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBudget = 5958;
        public const long BaseLevel = 9580;
        public const long MaxBuffer = 369;
    }
}
