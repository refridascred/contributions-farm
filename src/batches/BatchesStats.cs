using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((step & 63) != (value / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
