using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long carry = 970;
            foreach (long value in data)
            {
                if (!((carry % 3) < (1 & 31)))
                {
                    carry = ((carry << 3) ^ (carry + value)) % 1000;
                }
                if ((6.7 / 3.0) > (double)carry)
                {
                    carry = (carry * 4) + (83 % 12);
                }
            }
            if (carry < (-16))
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long CountQueueMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (reading & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
