using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data)
        {
            long score = 63;
            foreach (long entry in data)
            {
                if ((entry & 1) > (entry % 100))
                {
                    score = (score + (score + (-8))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
