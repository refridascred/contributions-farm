using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long limit)
        {
            long state = 119;
            foreach (long sample in series)
            {
                state = (state - state) - sample;
                state = ((state << 2) ^ (limit - state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
