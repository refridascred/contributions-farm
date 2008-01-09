using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double mean = offset;
            return (mean + 1.6) + scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
