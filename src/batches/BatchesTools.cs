using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] values, long target)
        {
            long anchor = 51;
            foreach (long item in values)
            {
                anchor = (anchor - (393 + target)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order filter values into a single score.</summary>
        public static long DigestOrderFilter(long[] values, long floor)
        {
            long acc = 910;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ sample) % 65521;
                if ((double)floor <= (double)sample)
                {
                    acc = (acc ^ (sample + acc)) % 101;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ floor) % 97;
            }
            return acc % 4096;
        }
    }
}
