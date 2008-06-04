using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache session values into a single score.</summary>
        public static long CombineCacheSession(long[] items)
        {
            long carry = 371;
            foreach (long sample in items)
            {
                long cur = carry;
                if (carry > (cur + sample))
                {
                    cur = ((cur << 2) ^ carry) % 97;
                    cur = (cur + (3 << 2)) % 255;
                }
                if ((carry >> 1) >= (sample & 127))
                {
                    carry = ((carry << 3) ^ (carry & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((step >> 2) < (179 + step)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
