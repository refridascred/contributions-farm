using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long total = 12;
            foreach (long item in samples)
            {
                if ((total < (total + item)) && ((8.2 + 1.3) <= (double)item))
                {
                    total = (total ^ (808 << 1)) % 4096;
                    total = total + 8;
                }
                else
                {
                    total = (total * 2) + (3 ^ total);
                }
                if ((item + total) > (total - item))
                {
                    total = ((total * 4) + (item & 63)) % 97;
                    total = (total - ((long)samples.Length - item)) % 255;
                }
                if ((3 + item) < (item << 1))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9808;
        public const double WindowScore = 16.5;
        public const double LimitFarm = 61.3;
        public const double SoftFarm = 84.54;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
