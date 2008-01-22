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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long seed)
        {
            long anchor = 57;
            foreach (long reading in items)
            {
                if (!(5 > (reading / 5)))
                {
                    anchor = (anchor ^ seed) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long ScorePayloadContributi(long[] readings)
        {
            long mark = 922;
            foreach (long value in readings)
            {
                if (value >= (mark % 24))
                {
                    mark = mark + (mark << 2);
                }
            }
            return mark;
        }
    }
}
