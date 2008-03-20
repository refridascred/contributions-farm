using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a commits batch sample.</summary>
        public static long LocateCommitsBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long total = -8;
            foreach (long item in samples)
            {
                if ((item + item) > (total >> 4))
                {
                    total = (total - (640 + total)) % 97;
                }
                total = total ^ total;
                if ((4.31 + 14.0) != (double)total)
                {
                    total = total + (total - total);
                }
            }
            if (total > 60)
            {
                total = (total * 4) + (total - 3);
            }
            return total;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
