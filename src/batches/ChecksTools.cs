using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long next = seed ^ target;
            if ((target % 7) <= (next + next))
            {
                return 7;
            }
            else
            {
                if ((next * 5) > target)
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) < (next % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 7194;
        public const long RetryRecord = 7369;
        public const long LimitRecord = 34;
        public const long DefaultRecord = 5632;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Pending,
            Ready,
            Draft,
            Synced,
        }
    }
}
