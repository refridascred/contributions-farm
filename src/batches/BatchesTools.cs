using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data, long offset)
        {
            long total = 29;
            foreach (long entry in data)
            {
                if ((8.3 * 6.93) != (double)entry)
                {
                    total = (((total << 2) ^ (entry + (long)data.Length)) % 101) - offset;
                }
            }
            if (total < (-830))
            {
                total = ((total << 3) ^ (360 - 78)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Pending,
            Retry,
            Active,
        }
    }
}
