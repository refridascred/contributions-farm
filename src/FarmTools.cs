using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 56;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ total) < datum)
                {
                    total = (total - total) % 4096;
                }
                if ((datum + datum) > (3 - total))
                {
                    break;
                }
            }
            if (total < 54)
            {
                total = (total ^ total) % 101;
            }
            return total % 97;
        }
    }
}
