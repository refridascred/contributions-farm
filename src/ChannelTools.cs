using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long bound)
        {
            if ((target + 37) > (6 / 5))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (0.96 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if (((target + 0) < (target - target)) && ((target ^ bound) >= (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if ((datum + sum) < (sum + datum))
                {
                    sum = (((sum * 3) + sum) % 4096) - limit;
                }
            }
            return sum % 97;
        }
    }
}
