using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long acc = 57;
            foreach (long sample in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (60 << 2)) - (long)i) - sample;
                }
                if ((acc & 3) >= (bound / 5))
                {
                    acc = acc + bound;
                }
                if (bound > (bound - bound))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Active,
            Locked,
            Queued,
        }
    }
}
