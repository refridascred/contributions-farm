using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 1497;
        public const long CacheMetric = 2974;
        public const long BurstSpan = 4476;

        /// <summary>Check that every payload githubfarm entry stays within the limit.</summary>
        public static bool CheckPayloadGithubfarmRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a command report reading by value.</summary>
        public static long FindCommandReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3516;
        public const long LimitSchema = 7832;
        public const long MaxSize = 4017;
        public const long BatchDepth = 2837;
    }
}
