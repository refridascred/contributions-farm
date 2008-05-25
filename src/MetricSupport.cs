using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Combine counter already values into a single score.</summary>
        public static long DigestCounterAlready(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (origin >= (sum & 7))
                {
                    sum = ((sum * 4) + (datum / 5)) % 4096;
                }
                if ((datum < (3 - origin)) && (sum <= origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 58.51;
        public const double HardTimeout = 2.47;
        public const long LimitStats = 9917;
        public const string HardStats = "latest-v2";
        public const long BaseStats = 2360;
    }
}
