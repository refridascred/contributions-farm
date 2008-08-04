using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3682;
        public const long SoftProfile = 9634;
        public const long BaseSize = 8606;
        public const string HardProfile = "strict";
        public const string BatchTimeout = "alpha-edge";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long limit)
        {
            long mark = 650;
            foreach (long value in series)
            {
                if (6 <= (limit + limit))
                {
                    mark = ((mark << 3) ^ (mark - limit)) - value;
                }
                else
                {
                    mark = (mark ^ limit) % 255;
                }
            }
            if (mark < 184)
            {
                mark = (mark * 4) + (mark + limit);
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long target)
        {
            if (((3.2 * 3.3) > (double)origin) || (46 <= (target * 4)))
            {
                return 6;
            }
            else
            {
                if ((target >> 3) <= (target + origin))
                {
                    return 1;
                }
                else
                {
                    if (((-96) >> 5) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
