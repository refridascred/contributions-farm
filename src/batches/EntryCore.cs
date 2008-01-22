using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long diff = target + origin;
            if ((diff + target) > 214)
            {
                return 7;
            }
            else
            {
                if (diff < (169 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((target - target) <= (target + 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) > (origin - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSize = 6819;
        public const long MinSpan = 4545;
        public const double StepCommits = 65.36;
        public const long DefaultDepth = 1760;
    }
}
