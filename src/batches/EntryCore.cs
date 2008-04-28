using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowWidth = 9.86;
        public const long LimitDepth = 1401;
        public const string CacheTimeout = "local-edge";
        public const string RetryCount = "latest-edge";

        /// <summary>Combine token channel values into a single score.</summary>
        public static long FoldTokenChannel(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                acc = ((acc << 3) ^ (reading + (-2))) % 1000;
                if (reading <= (reading << 2))
                {
                    acc = ((acc << 2) ^ reading) % 65521;
                }
                else
                {
                    acc = acc + (reading % 3);
                }
            }
            return acc;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
