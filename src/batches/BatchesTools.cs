using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Locked,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Iterate the batch account series from a seed.</summary>
        public static long IterateBatchAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((7.6 / 8.0) == (double)(long)i)
                {
                    carry = (carry + (step + step)) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry * 2) + (carry * 5)) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
