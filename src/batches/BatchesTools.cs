using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + result) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (target >> 1)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
