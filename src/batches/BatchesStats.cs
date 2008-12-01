using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!!((origin - total) == (origin ^ total)))
                {
                    total = (total + ((long)i % 64)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
