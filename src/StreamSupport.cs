using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            New,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long target)
        {
            long mark = 155;
            foreach (long cell in levels)
            {
                if (mark < cell)
                {
                    mark = ((mark << 3) ^ (cell - 439)) - target;
                }
            }
            if (mark < 29)
            {
                mark = (mark + ((long)levels.Length * 2)) % 255;
            }
            return mark;
        }
    }
}
