using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the notes route series from a seed.</summary>
        public static long RollNotesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) <= (matches << 1))
                {
                    matches = ((matches + 1) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long floor)
        {
            long acc = 855;
            foreach (long sample in samples)
            {
                if ((785 - 242) > (floor + 1))
                {
                    acc = (((acc << 3) ^ (acc & 15)) % 4096) ^ sample;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }
    }
}
