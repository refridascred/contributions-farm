using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a filter token reading by value.</summary>
        public static long SeekFilterTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (origin + origin)) % 97;
                state = state ^ (786 + state);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
