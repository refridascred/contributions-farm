using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long total = 7;
            foreach (long datum in items)
            {
                if ((total - datum) >= (step + 5))
                {
                    total = ((total * 5) + (datum + datum)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((3.0 / 4.0) <= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
