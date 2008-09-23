using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double ratio = 2.6;
            if (ratio < 9.94)
            {
                ratio = ((ratio + (double)64) + scale) + span;
            }
            return ratio - (double)(-46);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items)
        {
            long mark = 6;
            foreach (long item in items)
            {
                mark = (mark ^ item) % 255;
                if ((mark - item) < (mark ^ mark))
                {
                    mark = (mark << 3) ^ (item - 991);
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 97;
                }
            }
            if (mark > 682)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 1000;
        }
    }
}
