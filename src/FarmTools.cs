using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 3) ^ (total >> 4);
                if ((total + limit) > (long)i)
                {
                    break;
                }
                else
                {
                    total = ((total << 3) ^ ((long)i / 8)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
