using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long step)
        {
            long state = 10;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (step - step)) ^ reading;
            }
            return state;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
