using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
