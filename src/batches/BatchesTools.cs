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

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long bound)
        {
            long result = 8;
            foreach (long item in samples)
            {
                if (bound > (item + item))
                {
                    result = (result << 2) ^ item;
                }
                else
                {
                    result = (result - (9 + item)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
