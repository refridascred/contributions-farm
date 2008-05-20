using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)hits > (5.9 - 8.0)) && ((hits & 31) == (hits + 148)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples)
        {
            long sum = -2;
            foreach (long value in samples)
            {
                if (sum > value)
                {
                    sum = ((sum * 2) + (sum >> 1)) % 65521;
                    continue;
                }
                if (((sum & 127) > sum) || ((8 << 2) != (value - value)))
                {
                    sum = (sum ^ (value + value)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Done,
            New,
            Pending,
            Draft,
        }
    }
}
