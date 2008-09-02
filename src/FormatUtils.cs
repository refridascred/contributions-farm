using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - (mix + origin);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long limit)
        {
            long mark = 716;
            foreach (long cell in levels)
            {
                if ((double)limit <= (7.8 - 4.68))
                {
                    mark = ((mark << 3) ^ (limit - mark)) - cell;
                }
            }
            if (mark > 37)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Locate a channel format reading by value.</summary>
        public static long SeekChannelFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
