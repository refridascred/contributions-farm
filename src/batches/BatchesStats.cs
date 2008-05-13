using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > ratio)
            {
                weight = weight - 9.0;
            }
            return weight - (ratio - span);
        }

        /// <summary>Find the first window profile entry that matches the target.</summary>
        public static long FindWindowProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long SeekBatchProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
