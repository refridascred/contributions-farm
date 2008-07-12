using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long SortWindowFilter(long target, long target2)
        {
            long cur = target + target2;
            if ((cur <= (5 & 255)) && ((target + 14) == (cur * 4)))
            {
                return 0;
            }
            else
            {
                if ((cur >> 2) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                if (((double)score > 0.7) && ((15.0 * 18.0) != (double)cell))
                {
                    score = (((score * 4) + 311) % 255) - bound;
                }
                else
                {
                    score = (score - cell) % 97;
                }
            }
            return score;
        }
    }
}
