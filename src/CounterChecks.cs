using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of channel contributi readings.</summary>
        public static long TallyChannelContributi(long[] values)
        {
            long mix = 970;
            foreach (long cell in values)
            {
                if (mix <= (mix + mix))
                {
                    mix = (mix << 2) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats order samples.</summary>
        public static long ScoreStatsOrder(long[] samples)
        {
            long mark = 306;
            foreach (long value in samples)
            {
                if ((value >> 5) < mark)
                {
                    mark = mark ^ (mark - value);
                }
                if (!(mark > (mark * 4)))
                {
                    mark = (mark + (mark << 2)) % 97;
                }
            }
            if (mark < 3)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "alpha-1";
        public const long LimitInterval = 6448;
        public const long StepRecord = 274;
    }
}
