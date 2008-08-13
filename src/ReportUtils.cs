using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the format session series from a seed.</summary>
        public static long IterateFormatSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed ^ seed) != ((long)i % 5))
                {
                    anchor = (anchor + (seed - anchor)) % 101;
                    break;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i + 7)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if (!(mark > (reading * 3)))
                {
                    mark = (mark ^ (mark & 1)) % 65521;
                }
                if ((mark / 6) <= (step ^ mark))
                {
                    mark = ((mark * 3) + (133 * 3)) % 65521;
                }
            }
            if (mark < 351)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }
    }
}
