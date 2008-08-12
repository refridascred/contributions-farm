using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count command stream pairs that satisfy a relation.</summary>
        public static long MatchCommandStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long BucketContributiFormat(long seed, long seed2)
        {
            if (((8.5 * 5.4) >= (double)seed2) && ((seed * 2) == (seed + 8)))
            {
                return 3;
            }
            else
            {
                if ((double)(-308) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
