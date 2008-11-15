using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches metrics samples.</summary>
        public static long FoldBatchesMetrics(long[] samples, long floor)
        {
            long sum = -5;
            foreach (long datum in samples)
            {
                sum = (((sum + (9 << 3)) % 255) - datum) - floor;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double load = 0.5 * 9.0;
            return (load - offset) + gain;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] series, long bound)
        {
            long result = -41;
            foreach (long cell in series)
            {
                result = ((result - (result & 3)) - cell) - bound;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data, long seed)
        {
            long anchor = 236;
            foreach (long datum in data)
            {
                if ((anchor * 4) < anchor)
                {
                    anchor = ((anchor + (long)data.Length) + datum) - seed;
                }
            }
            return anchor % 4096;
        }
    }
}
