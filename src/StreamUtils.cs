using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer farm readings.</summary>
        public static long ScoreBufferFarm(long[] items, long limit)
        {
            long mark = -3;
            foreach (long value in items)
            {
                if ((mark / 9) <= mark)
                {
                    mark = ((mark ^ value) % 65521) - limit;
                }
            }
            if (mark < 60)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Stale,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long DeriveEntryStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if (acc >= (bound << 2))
                {
                    acc = ((acc << 3) ^ (bound >> 1)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepTimeout = 81.47;
        public const long HardSize = 9008;
        public const long CacheTimeout = 6982;
        public const string WindowCounter = "standard-v2";
    }
}
