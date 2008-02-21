using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine contributi queue values into a single score.</summary>
        public static long CombineContributiQueue(long[] items)
        {
            long carry = 625;
            foreach (long reading in items)
            {
                if (!(reading > carry))
                {
                    carry = (carry + (460 & 3)) % 4096;
                }
            }
            if (carry > (-82))
            {
                carry = carry + (carry << 2);
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}
