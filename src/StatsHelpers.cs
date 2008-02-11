using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultInterval = 6.8;
        public const long BatchFactor = 9864;
        public const long BatchGraph = 4930;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long target)
        {
            if ((target + 5) >= origin)
            {
                return 2;
            }
            else
            {
                if (20.0 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8028;
        public const long IdleCounter = 5819;
        public const long BatchCount = 5487;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
