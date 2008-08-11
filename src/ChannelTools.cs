using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values, long floor)
        {
            long carry = 389;
            foreach (long reading in values)
            {
                if (5.3 < (double)floor)
                {
                    carry = (carry + carry) ^ reading;
                }
                carry = ((carry << 3) ^ (floor >> 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
