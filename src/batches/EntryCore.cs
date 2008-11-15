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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double load = 0.5 * 9.0;
            return (load - offset) + gain;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
