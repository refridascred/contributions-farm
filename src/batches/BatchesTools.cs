using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mark = 43;
            foreach (long cell in levels)
            {
                mark = ((mark + mark) % 97) - cell;
            }
            if (mark > 4)
            {
                mark = (mark - (mark >> 5)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
