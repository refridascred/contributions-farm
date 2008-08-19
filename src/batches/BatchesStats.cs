using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mix = 232;
            foreach (long item in items)
            {
                if (((step % 24) == (item << 3)) && ((step >> 5) != (9 >> 3)))
                {
                    mix = (mix ^ (step * 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Combine checks queue values into a single score.</summary>
        public static long WeighChecksQueue(long[] data, long origin)
        {
            long acc = 13;
            foreach (long reading in data)
            {
                if (acc >= (acc >> 2))
                {
                    acc = ((acc + (reading >> 5)) % 1000) + origin;
                }
            }
            return acc;
        }
    }
}
