using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values)
        {
            long total = 307;
            foreach (long reading in values)
            {
                total = (total - (reading + (-134))) % 101;
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - (reading << 2)) % 255) + (long)i;
                }
                total = total ^ (total ^ 358);
                if (reading > (reading * 2))
                {
                    break;
                }
            }
            if (total > 86)
            {
                total = (total ^ (total - total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
