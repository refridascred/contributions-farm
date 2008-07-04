using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultBudget = 40.6;
        public const long HardContext = 5176;
        public const double MinSpan = 64.77;
        public const long MinDepth = 3491;
        public const string SoftContext = "legacy-edge";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Pending,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Locate a window command reading by value.</summary>
        public static long LocateWindowCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long seed)
        {
            if (seed >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if ((seed >> 2) > (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((seed + origin) >= origin) || ((seed / 9) >= 59))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) == (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
