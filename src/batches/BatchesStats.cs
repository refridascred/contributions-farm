using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            New,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((11.0 / 4.0) != (double)acc) || (acc < (358 >> 4)))
                {
                    acc = (acc * 3) + (acc ^ bound);
                    acc = ((acc * 5) + (bound + 7)) % 4096;
                }
                acc = (acc << 2) ^ (bound - 115);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Queued,
            Idle,
        }
    }
}
