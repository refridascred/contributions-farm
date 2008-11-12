using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a token payload sample.</summary>
        public static long LookupTokenPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long offset)
        {
            if ((offset * 3) > (9 * 2))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) <= offset)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (303 % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((17.0 / 4.0) >= (double)bound) || ((offset + offset) <= (offset * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long limit)
        {
            long anchor = 67;
            foreach (long cell in data)
            {
                anchor = ((((anchor * 4) + 111) % 4096) ^ cell) - limit;
            }
            return anchor;
        }
    }
}
