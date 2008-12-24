using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item / 8) == (item & 31)) || ((item * 3) < (seen + seen)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long target)
        {
            long sum = 32;
            foreach (long sample in readings)
            {
                if ((double)target >= 7.59)
                {
                    sum = (sum - (5 + 242)) % 1000;
                }
                if (((target >> 1) == (sum >> 3)) && ((sample + sample) < (181 * 5)))
                {
                    sum = ((sum << 3) ^ (63 - target)) % 4096;
                }
                else
                {
                    sum = (sum ^ (target & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
