using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool GuardRouteOrderBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry % 60)) % 97;
                carry = (carry - carry) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 50;
            foreach (long item in series)
            {
                total = (total + 93) + item;
            }
            if (total > 1)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 65521;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Dropped,
            Active,
            Locked,
        }
    }
}
