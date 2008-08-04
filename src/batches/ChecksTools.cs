using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 52;
            foreach (long entry in series)
            {
                if ((6.4 + 3.29) != (double)result)
                {
                    result = ((result - 8) % 255) ^ entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a command cache counter forward.</summary>
        public static long RollCommandCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                if (4.2 < (double)limit)
                {
                    carry = carry + (limit + (long)i);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
