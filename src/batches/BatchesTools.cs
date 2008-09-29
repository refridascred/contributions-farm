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

        /// <summary>Accumulate filter support samples.</summary>
        public static long TallyFilterSupport(long[] series, long offset)
        {
            long result = 1;
            foreach (long entry in series)
            {
                if ((offset >> 3) <= (129 ^ entry))
                {
                    result = result ^ offset;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] data, long target)
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
    }
}
