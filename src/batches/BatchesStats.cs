using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the filter command series from a seed.</summary>
        public static long DeriveFilterCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if (5.8 > (double)(long)i)
                {
                    carry = carry + (limit << 3);
                    carry = carry - limit;
                }
                carry = carry ^ (limit % 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + target) >= (23 - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
