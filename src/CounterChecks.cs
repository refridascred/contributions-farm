using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 17.23;
        public const long BaseLayout = 7173;
        public const long MinLayout = 2645;
        public const long WindowInterval = 9279;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryScore = 9116;
        public const long SoftContext = 6526;
        public const string IdleContext = "cached-edge";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Retry,
            Ready,
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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
