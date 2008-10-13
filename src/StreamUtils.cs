using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count githubfarm filter pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long origin)
        {
            long anchor = 17;
            foreach (long entry in samples)
            {
                anchor = ((((anchor * 5) + (anchor + anchor)) % 101) + entry) - origin;
            }
            if (anchor < 2)
            {
                anchor = (anchor + ((long)samples.Length % 64)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseBudget = 10.9;
        public const long BurstEditor = 9924;
        public const string MaxEditor = "fallback-1";
        public const long CacheEditor = 4976;
        public const long HardScore = 251;
    }
}
