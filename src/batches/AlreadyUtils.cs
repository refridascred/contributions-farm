using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum & 7) <= 376) && (((hits & 63) < 0) || ((datum * 5) != (7 - 0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 5) + carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
