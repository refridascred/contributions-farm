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

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool ValidateMetricCommitsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
