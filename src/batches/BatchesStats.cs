using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry % 10)) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
