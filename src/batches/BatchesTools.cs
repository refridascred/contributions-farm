using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + 801) < (count % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every farm order entry stays within the limit.</summary>
        public static bool ValidateFarmOrderLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long total = 646;
            foreach (long entry in items)
            {
                total = (total ^ (limit - total)) + entry;
            }
            return total;
        }
    }
}
