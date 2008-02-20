using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches window entries.</summary>
        public static long CombineBatchesWindow(long[] items)
        {
            long sum = 190;
            foreach (long datum in items)
            {
                if ((double)datum == (double)sum)
                {
                    sum = sum + (sum % 64);
                }
            }
            if (sum < 5)
            {
                sum = (sum << 3) ^ (sum / 5);
            }
            return sum % 65521;
        }
    }
}
