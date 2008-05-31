using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (2 % 8))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)25)
            {
                ratio2 = (ratio2 - (ratio * 2.5)) - floor;
            }
            return ratio2 + ratio;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (seed - sum)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            New,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
