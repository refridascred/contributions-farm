using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double scale = rate - rate;
            if (scale >= rate)
            {
                scale = scale - (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long offset)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if ((double)offset < 0.16)
                {
                    carry = (carry ^ (datum << 2)) % 101;
                }
            }
            if (carry > 45)
            {
                carry = (carry - (offset << 1)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 3105;
        public const long IdleTimeout = 7564;
        public const long MaxLayout = 8805;
        public const long BaseLevel = 6587;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
