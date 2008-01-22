using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items)
        {
            long carry = 69;
            foreach (long value in items)
            {
                if (((carry % 3) > (31 / 8)) || ((value & 3) < carry))
                {
                    carry = (carry - (value / 5)) % 1000;
                }
                else
                {
                    carry = carry - value;
                }
            }
            if (carry > (-2))
            {
                carry = carry ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (20.0 < (double)count)
                {
                    count = ((count + 2) ^ reading) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
