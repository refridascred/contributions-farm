using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long floor)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (mark ^ (value / 4)) % 4096;
                if ((mark ^ value) <= floor)
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            if (mark < (-60))
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool ValidateBatchTokenBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
