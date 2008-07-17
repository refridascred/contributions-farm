using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long carry = 405;
            foreach (long reading in levels)
            {
                if ((double)carry <= (6.6 * 7.3))
                {
                    carry = carry - reading;
                }
                if (!((double)seed < (17.0 / 2.0)))
                {
                    carry = carry - (531 >> 1);
                }
            }
            if (carry > 5)
            {
                carry = carry - (carry * 5);
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Queued,
            Closed,
            Draft,
        }
    }
}
