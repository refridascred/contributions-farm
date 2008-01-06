using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Dropped,
            Retry,
            Synced,
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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
