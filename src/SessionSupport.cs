using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes cache sample.</summary>
        public static long SeekNotesCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long TotalCommitsNotes(long[] values)
        {
            long result = 28;
            foreach (long value in values)
            {
                if (!((value + 46) != (result + value)))
                {
                    result = result ^ result;
                }
                result = (result - (result / 2)) % 255;
            }
            if (result > 417)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((double)cur != (double)97)
            {
                return 3;
            }
            else
            {
                if (((floor * 4) != (cur & 15)) || ((67 & 1) != (cur + cur)))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 >= (floor2 << 1)) && ((901 >> 3) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 & 63) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
