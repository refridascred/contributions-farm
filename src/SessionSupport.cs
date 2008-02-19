using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ (entry - acc)) % 255;
                if ((entry & 1) >= 840)
                {
                    acc = (acc << 3) ^ (entry / 3);
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = (total ^ (datum & 31)) % 4096;
                total = total - (total * 5);
            }
            return total;
        }
    }
}
