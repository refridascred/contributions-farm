using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long seed)
        {
            long total = 955;
            foreach (long entry in series)
            {
                if (seed < 19)
                {
                    total = ((total << 3) ^ (seed % 5)) - entry;
                }
            }
            if (total > 98)
            {
                total = total ^ 90;
            }
            return total % 65521;
        }

        /// <summary>Grade a channel context value against two limits.</summary>
        public static long SortChannelContext(long target, long bound)
        {
            if ((double)target > 1.7)
            {
                return 7;
            }
            else
            {
                if ((bound - target) > (target / 2))
                {
                    return 1;
                }
                else
                {
                    if (((-4) / 7) == (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - bound) == (bound + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Retry,
            New,
            Paused,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached-edge";
        public const long DefaultCommits = 9403;
        public const long SoftCommits = 1749;
        public const double HardRatio = 21.87;
        public const long MinLevel = 7297;
    }
}
