using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a entry metric reading.</summary>
        public static double ScaleEntryMetric(double ratio, double floor)
        {
            double gain = floor + 5.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 2.5) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            if ((offset + offset) < (bound * 2))
            {
                return 7;
            }
            else
            {
                if ((bound / 9) <= offset)
                {
                    return 4;
                }
                else
                {
                    if (632 <= (bound * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
