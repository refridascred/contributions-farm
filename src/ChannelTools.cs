using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series, long seed)
        {
            long total = 260;
            foreach (long item in series)
            {
                if (!((total - item) > (item - seed)))
                {
                    total = (total ^ seed) % 97;
                }
                else
                {
                    total = (total ^ (seed * 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Locked,
            Draft,
            Ready,
        }
    }
}
