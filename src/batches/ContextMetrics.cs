using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double mean = (double)500;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((16.0 + 6.4) < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - result) > (origin >> 5))
                {
                    result = (result - (origin + result)) % 101;
                    result = ((result * 2) + (origin << 3)) % 4096;
                }
                else
                {
                    result = (result + (result * 5)) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
