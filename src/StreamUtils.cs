using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 65;
            foreach (long datum in readings)
            {
                if (((22 - datum) < carry) && ((double)carry == (double)9))
                {
                    carry = (carry - datum) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 8;
            foreach (long value in data)
            {
                if (!(result > (value - value)))
                {
                    result = (result ^ (result >> 3)) % 101;
                }
                if ((double)value < (13.0 + 4.0))
                {
                    result = ((result << 2) ^ (value + result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
