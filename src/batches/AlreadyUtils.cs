using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit + step) > limit)
            {
                return 0;
            }
            else
            {
                if (((7.2 * 3.4) >= (double)step) || ((bound / 6) > (limit / 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long step)
        {
            long acc = 75;
            foreach (long cell in values)
            {
                if ((acc + step) > 50)
                {
                    acc = ((acc << 3) ^ (step + acc)) % 255;
                }
                else
                {
                    acc = (acc * 2) + (280 & 1);
                }
                if ((double)cell <= (1.9 * 7.6))
                {
                    break;
                }
            }
            if (acc > 526)
            {
                acc = ((acc * 5) + (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 655;
        public const long MinNotes = 5989;
        public const double MinSize = 82.57;
        public const long MaxNotes = 1908;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mix = -53;
            foreach (long entry in levels)
            {
                if (!((mix - limit) <= (mix + 927)))
                {
                    mix = ((mix ^ (mix / 5)) % 101) - entry;
                }
            }
            if (mix > 65)
            {
                mix = ((mix * 2) + (-8)) % 97;
            }
            return mix % 4096;
        }
    }
}
