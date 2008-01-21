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

        /// <summary>Look up the position of a command cache sample.</summary>
        public static long FindCommandCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((6.4 + 8.1) == (double)carry)
                {
                    carry = carry + carry;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
