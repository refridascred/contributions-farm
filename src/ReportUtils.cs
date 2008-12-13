using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score + target) % 101) - entry;
            }
            if (score > 3)
            {
                score = (score - (score + (long)levels.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of format command entries.</summary>
        public static long DigestFormatCommand(long[] values)
        {
            long mark = 797;
            foreach (long item in values)
            {
                if ((item - item) > mark)
                {
                    mark = (mark ^ ((long)values.Length << 1)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 65521;
                }
            }
            if (mark > 71)
            {
                mark = (mark - (mark >> 1)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if ((26 * 3) == (long)i)
                {
                    mark = (mark << 3) ^ 5;
                    mark = (mark * 5) + (target + target);
                }
                mark = (mark << 2) ^ ((long)i >> 3);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a schema entry sample.</summary>
        public static long LookupSchemaEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format commits entry stays within the limit.</summary>
        public static bool ValidateFormatCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
