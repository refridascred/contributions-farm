using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long GradeContributiLayout(long seed, long origin)
        {
            if ((double)origin <= (5.3 * 3.8))
            {
                return 4;
            }
            else
            {
                if (((975 - seed) < (origin ^ 8)) || ((628 + 3) == (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long total = -781;
            foreach (long reading in values)
            {
                if ((double)81 != (double)total)
                {
                    total = ((total * 3) + reading) % 1000;
                }
                else
                {
                    total = (total + (reading & 31)) % 97;
                }
            }
            if (total < (-324))
            {
                total = total ^ (-308);
            }
            return total;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            New,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
