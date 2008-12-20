using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of counter profile entries.</summary>
        public static long TotalCounterProfile(long[] levels)
        {
            long anchor = 65;
            foreach (long value in levels)
            {
                anchor = anchor - value;
                if ((anchor + value) <= (value >> 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 7878;
        public const long MaxFactor = 7569;
        public const double BaseFarm = 59.71;
        public const long BurstTimeout = 5071;

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Count tools cluster pairs that satisfy a relation.</summary>
        public static long MatchToolsClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
