using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 5092;
        public const double DefaultBatch = 66.07;
        public const string LimitBatch = "strict-edge";

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long bound)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if ((4 >= bound) && ((bound & 63) < (anchor - bound)))
                {
                    anchor = ((anchor * 5) + (anchor - anchor)) ^ cell;
                }
            }
            return anchor;
        }
    }
}
