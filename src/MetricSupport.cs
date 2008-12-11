using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long carry = 346;
            foreach (long cell in series)
            {
                carry = ((carry - (carry & 127)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long acc = -78;
            foreach (long value in levels)
            {
                acc = (acc + acc) + value;
            }
            return acc;
        }
    }
}
