using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings, long bound)
        {
            long acc = 978;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (datum - acc)) + bound;
            }
            return acc % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                if (((mix / 3) <= 86) || ((item - 2) < (seed - (long)levels.Length)))
                {
                    mix = mix - (seed + mix);
                }
                if ((double)seed >= (3.1 * 12.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
