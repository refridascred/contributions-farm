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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
