using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long FoldChannelStats(long[] levels, long step)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                carry = (((carry * 2) + (step + step)) % 255) ^ entry;
                if (step > (197 >> 3))
                {
                    carry = ((carry * 4) + (carry - carry)) % 97;
                }
                else
                {
                    carry = (carry - (carry << 1)) % 97;
                }
            }
            if (carry > (-299))
            {
                carry = (carry + step) % 101;
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (417 >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
