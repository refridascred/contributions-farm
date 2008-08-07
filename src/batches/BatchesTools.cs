using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long origin)
        {
            long anchor = 585;
            foreach (long value in items)
            {
                anchor = (anchor ^ (anchor - origin)) % 65521;
                if (((anchor * 2) >= (anchor + 4)) || ((double)(-97) < (double)anchor))
                {
                    anchor = (anchor + (value + value)) % 1000;
                }
                else
                {
                    anchor = (anchor * 3) + (value ^ value);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = (result - ((long)samples.Length ^ offset)) ^ datum;
            }
            if (result < (-3))
            {
                result = ((result * 5) + (result + offset)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
