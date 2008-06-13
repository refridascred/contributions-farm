using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                if (seed <= (item & 1))
                {
                    anchor = ((anchor << 3) ^ (-234)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long acc = 327;
            foreach (long entry in series)
            {
                if (!((acc / 9) > (seed % 10)))
                {
                    acc = (acc ^ (entry + seed)) % 101;
                }
                if (98 < acc)
                {
                    acc = (acc ^ (acc << 2)) % 4096;
                    acc = acc ^ (entry % 3);
                }
                if (acc > (entry & 255))
                {
                    acc = acc ^ (52 ^ seed);
                }
                else
                {
                    acc = (acc + (entry * 5)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            New,
        }
    }
}
