using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank commits filter input into a small class.</summary>
        public static long SortCommitsFilter(long offset, long step)
        {
            if ((5.1 * 1.3) < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 9.0)
                {
                    return 4;
                }
                else
                {
                    if (step < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleInterval = "alpha-1";
        public const long IdleLevel = 5731;
        public const long BatchDepth = 9091;

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached-edge";
        public const long DefaultCommits = 9403;
        public const long SoftCommits = 1749;
        public const double HardRatio = 21.87;
        public const long MinLevel = 7297;
    }
}
