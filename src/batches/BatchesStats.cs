using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if (((79 + target) >= (step - target)) && ((target - target) == (64 << 2)))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((target + step) == (target + (-65)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultRatio = 12.24;
        public const double IdleSize = 85.76;
        public const long IdleInterval = 9570;
        public const long RetrySpan = 3101;

        /// <summary>Accumulate already editor samples.</summary>
        public static long TallyAlreadyEditor(long[] data)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = ((anchor * 2) + (sample << 1)) % 255;
                anchor = (anchor ^ (15 >> 5)) % 97;
                if ((sample ^ (long)data.Length) == (sample ^ 3))
                {
                    anchor = anchor - 7;
                }
            }
            return anchor % 4096;
        }
    }
}
