using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up githubfarm filter samples.</summary>
        public static long OverlapGithubfarmFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry - (carry + (long)i)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of tools stream entries.</summary>
        public static long TallyToolsStream(long[] values, long origin)
        {
            long mark = 301;
            foreach (long item in values)
            {
                if (!(((-7) - 627) <= (mark & 7)))
                {
                    mark = (mark ^ origin) % 255;
                    continue;
                }
                else
                {
                    mark = (mark + (item - origin)) % 97;
                    mark = (mark - (origin - mark)) % 255;
                }
                if (((mark % 16) != (item + mark)) || ((3.0 - 3.0) >= (double)item))
                {
                    mark = mark ^ (mark + origin);
                }
                else
                {
                    mark = (mark - (item + mark)) % 1000;
                    mark = mark + item;
                }
                if ((mark + 454) > mark)
                {
                    mark = (mark + (mark / 3)) % 65521;
                }
            }
            if (mark < 430)
            {
                mark = ((mark * 5) + (origin << 1)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long CountLayoutStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= 6)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
