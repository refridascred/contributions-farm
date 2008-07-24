using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + hits) < 2)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double ratio = scale;
            return ratio - floor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            New,
            Active,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Closed,
            Draft,
            Active,
            Pending,
        }
    }
}
