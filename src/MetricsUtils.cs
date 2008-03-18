using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
