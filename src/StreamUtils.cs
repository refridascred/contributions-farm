using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseCount = 90.26;
        public const long RetrySize = 3503;
        public const long HardBudget = 5439;

        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double BlendProfileChannel(double scale, double span)
        {
            double weight = 6.65 + 16.0;
            if (weight > span)
            {
                weight = weight - (scale / 6.0);
            }
            return weight + (scale * 4.2);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((248 <= (count - count)) && ((seed & 255) < count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (6.01 + rate))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
