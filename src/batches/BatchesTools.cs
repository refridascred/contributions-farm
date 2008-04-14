using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((double)offset <= (3.06 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((18 & 15) < (origin - offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((score < (score << 2)) && ((score * 5) < (value + value)))
                {
                    score = ((score * 5) + (score - 862)) % 101;
                }
                if (11.0 < (double)value)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
