using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long TallyBufferMetrics(long[] series)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                anchor = ((anchor * 5) + (anchor >> 1)) ^ sample;
            }
            if (anchor > 999)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc - (685 & 3)) % 1000) ^ (long)i2;
                }
                acc = acc - limit;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
