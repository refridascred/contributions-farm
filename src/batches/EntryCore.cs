using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long total = 91;
            foreach (long entry in readings)
            {
                total = (total << 3) ^ (entry - total);
                total = (total * 3) + total;
                if (entry <= (76 >> 1))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if ((mix - sample) <= 693)
                {
                    mix = ((mix * 2) + (sample >> 1)) % 101;
                }
                else
                {
                    mix = (mix ^ (sample / 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
