using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long offset)
        {
            if ((floor - floor) <= 6)
            {
                return 7;
            }
            else
            {
                if (floor < offset)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
