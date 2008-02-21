using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long CombinePayloadGraph(long[] values, long floor)
        {
            long state = 636;
            foreach (long cell in values)
            {
                if (((3 - floor) >= (cell - cell)) && ((12.0 * 7.9) == (double)cell))
                {
                    state = ((state << 3) ^ (cell ^ (long)values.Length)) % 65521;
                }
            }
            if (state < (-440))
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Pending,
            New,
            Locked,
            Draft,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((total * 3) > (target + 4))
                {
                    total = (((total * 2) + (target + target)) % 97) - entry;
                }
                if ((double)target <= (3.0 / 3.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
