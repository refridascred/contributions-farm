using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + (355 >> 4)) % 1000) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
