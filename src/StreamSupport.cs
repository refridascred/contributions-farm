using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - ((long)i >> 4)) % 1000) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
