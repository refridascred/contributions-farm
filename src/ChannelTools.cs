using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (bound - 7);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
