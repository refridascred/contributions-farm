using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long carry = 33;
            foreach (long cell in items)
            {
                if ((cell * 5) > (carry + (long)items.Length))
                {
                    carry = (carry * 4) + (cell - 54);
                }
            }
            if (carry > 15)
            {
                carry = (carry + (carry + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
