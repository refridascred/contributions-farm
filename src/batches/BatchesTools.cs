using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((count << 3) > count) && (31 >= (550 + count))) && ((double)reading >= (17.0 + 1.1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((floor <= span) || ((limit + span) > (floor + span)))
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= span)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a schema cache reading by value.</summary>
        public static long LocateSchemaCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
