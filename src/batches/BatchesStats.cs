using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((5 + item) > 24)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long FoldFormatSession(long[] items)
        {
            long mix = -1;
            foreach (long datum in items)
            {
                if ((98 < datum) || ((mix & 1) <= mix))
                {
                    mix = mix + (89 * 5);
                }
                else
                {
                    mix = (mix << 3) ^ 135;
                }
            }
            if (mix < 91)
            {
                mix = (mix << 2) ^ (8 + mix);
            }
            return mix;
        }
    }
}
