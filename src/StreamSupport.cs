using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                if ((7 / 9) >= ((-817) ^ cell))
                {
                    carry = carry + (cell + 17);
                }
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
