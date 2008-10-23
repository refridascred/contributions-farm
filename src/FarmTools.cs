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

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
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
