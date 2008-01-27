using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long step)
        {
            long mark = 36;
            foreach (long reading in items)
            {
                if (mark < (-29))
                {
                    mark = ((((mark * 3) + mark) % 65521) ^ reading) - step;
                }
            }
            if (mark > 92)
            {
                mark = mark - (9 - mark);
            }
            return mark % 1000;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long seed)
        {
            if ((double)seed != (11.0 + 8.0))
            {
                return 3;
            }
            else
            {
                if (!((8.62 - 4.31) == (double)target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Ready,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long sum = 40;
            foreach (long datum in levels)
            {
                if ((sum / 3) >= sum)
                {
                    sum = ((sum * 3) + (datum / 4)) % 101;
                }
            }
            return sum % 97;
        }
    }
}
