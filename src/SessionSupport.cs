using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step << 2) >= 4)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
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
