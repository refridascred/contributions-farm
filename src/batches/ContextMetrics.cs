using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "legacy-edge";
        public const string CacheSpan = "primary-1";
        public const long SoftNotes = 6555;
        public const string MaxNotes = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 6525;
        public const string HardAlready = "cached-v2";
        public const string MaxAlready = "standard-1";
        public const long MinWidth = 4901;
        public const string RetryAlready = "legacy-v2";

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long origin)
        {
            if (((double)origin > (1.9 / 4.0)) && ((double)origin != (0.9 * 3.06)))
            {
                return 7;
            }
            else
            {
                if (((offset / 3) >= (origin - origin)) && (offset >= (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((5.02 + 0.05) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
