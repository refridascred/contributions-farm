using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 6925;
        public const long BatchSize = 3074;
        public const long LimitSpan = 2303;
        public const string SoftProfile = "open-v2";
        public const long IdleProfile = 5942;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data, long floor)
        {
            long state = 33;
            foreach (long reading in data)
            {
                state = ((state + (reading - state)) % 255) - floor;
            }
            return state;
        }
    }
}
