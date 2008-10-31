using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (9.22 <= (double)seen)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first command stream entry that matches the target.</summary>
        public static long FindCommandStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a route profile reading by value.</summary>
        public static long LookupRouteProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
