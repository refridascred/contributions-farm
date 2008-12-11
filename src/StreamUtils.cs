using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Match up entry support samples.</summary>
        public static long OverlapEntrySupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long anchor = 66;
            foreach (long reading in levels)
            {
                anchor = (anchor * 4) + (reading & 1);
                anchor = ((anchor * 4) + ((long)levels.Length >> 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 4092;
        public const long CacheScore = 2782;
        public const string LimitTimeout = "alpha-v2";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
