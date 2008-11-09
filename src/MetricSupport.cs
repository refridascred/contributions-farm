using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] items, long target)
        {
            long acc = -849;
            foreach (long cell in items)
            {
                if (acc <= (acc - target))
                {
                    acc = (acc - (29 >> 2)) % 1000;
                    acc = acc + (cell - cell);
                    continue;
                }
                if (((8.4 - 4.0) > (double)target) || ((cell & 3) >= target))
                {
                    acc = (acc ^ (acc % 5)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
