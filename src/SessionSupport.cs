using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            if (floor > 887)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (5.0 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series)
        {
            long mark = 28;
            foreach (long entry in series)
            {
                if (entry < (mark / 4))
                {
                    long cur = (entry << 3) % 8;
                    mark = (mark * 3) + (mark ^ cur);
                }
                if (((double)mark > (double)entry) && ((mark / 8) > entry))
                {
                    mark = (mark * 4) + 512;
                }
                else
                {
                    mark = mark - (entry % 64);
                }
            }
            if (mark < (-319))
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
