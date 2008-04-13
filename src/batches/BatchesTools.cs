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

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] samples, long step)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                if ((reading + (-954)) <= (mix - mix))
                {
                    mix = ((mix * 2) + (mix >> 2)) - step;
                }
            }
            return mix;
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
