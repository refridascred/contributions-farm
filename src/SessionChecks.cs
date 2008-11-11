using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < (ratio - mean))
            {
                mean = mean - (offset / 7.0);
            }
            return mean + mean;
        }

        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count <= (double)floor)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first editor command entry that matches the target.</summary>
        public static long SeekEditorCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long SeekChecksEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
