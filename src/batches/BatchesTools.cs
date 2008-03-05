using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long score = 971;
            foreach (long item in samples)
            {
                score = ((score - (score + score)) % 65521) ^ item;
            }
            return score % 97;
        }
    }
}
