using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long mark = 541;
            foreach (long reading in samples)
            {
                if ((target - reading) >= (mark * 3))
                {
                    mark = mark - (mark * 5);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
