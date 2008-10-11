using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a filter stream counter forward.</summary>
        public static long IterateFilterStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double mean = weight;
            return (mean - (mean - 7.07)) + offset;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long total = 411;
            foreach (long item in levels)
            {
                if ((double)item > (6.6 - 5.79))
                {
                    total = (total + (73 ^ total)) % 65521;
                }
                else
                {
                    total = (total ^ (total - item)) % 4096;
                }
            }
            return total;
        }
    }
}
