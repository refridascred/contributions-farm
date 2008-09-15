using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series, long target)
        {
            long total = 64;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total - ((long)i << 3)) ^ item;
                    total = (total << 2) ^ (total + target);
                }
                total = (total + target) % 1000;
                total = total - (1 + total);
            }
            return total;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long IterateClusterStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry >> 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 85.27;
        public const string WindowDepth = "fallback-v2";
        public const long BatchScore = 6183;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length << 3) >= (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
