using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long cell in samples)
            {
                bool flag = ((double)cell > (double)(long)samples.Length) || ((double)cell <= (double)offset);
                if (!flag)
                {
                    acc = (acc - (offset - offset)) % 255;
                }
                acc = (acc * 4) + (cell - cell);
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-1";
        public const long RetryContributi = 7132;
        public const long SoftDepth = 9216;
        public const long SoftWidth = 8675;
        public const long IdleBudget = 9246;

        /// <summary>Accumulate buffer contributi samples.</summary>
        public static long TallyBufferContributi(long[] data, long target)
        {
            long anchor = 244;
            foreach (long datum in data)
            {
                if ((5 >> 4) < (datum - 5))
                {
                    anchor = ((anchor - (158 / 9)) % 1000) - target;
                }
            }
            return anchor;
        }
    }
}
