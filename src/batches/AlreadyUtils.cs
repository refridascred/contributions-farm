using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((item << 1) < (seen * 4)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 76.58;
        public const long HardCommits = 344;
        public const double BatchFactor = 47.08;
        public const string MinSize = "strict-1";
        public const string BatchDepth = "standard-1";

        /// <summary>Locate a entry session reading by value.</summary>
        public static long LocateEntrySessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long CountProfileSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
