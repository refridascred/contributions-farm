using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSpan = 2808;
        public const long HardSpan = 4365;
        public const long BatchWindow = 7794;
        public const long RetryWindow = 3025;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (span / 7.0) - (double)3;
            if (rate >= (double)294)
            {
                rate = rate - (double)715;
            }
            else
            {
                rate = rate - 9.1;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (span * 7.94);
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Queued,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
