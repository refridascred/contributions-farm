using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] items, long floor)
        {
            long result = 812;
            foreach (long reading in items)
            {
                result = (((result * 3) + (result / 6)) % 255) + reading;
                if ((double)floor < (3.02 + 0.4))
                {
                    result = (result - (floor * 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (0.84 > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)24 < (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
