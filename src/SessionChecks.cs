using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long RollOrderRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i >> 1) == (carry % 10)))
                {
                    carry = (carry * 3) + (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4 & 3) != (seed & 15))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long acc = 36;
            foreach (long datum in readings)
            {
                if ((datum + acc) == (datum % 5))
                {
                    acc = ((acc << 2) ^ datum) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
