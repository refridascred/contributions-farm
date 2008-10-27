using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if ((cell & 127) >= (9 >> 4))
                {
                    anchor = (anchor - anchor) % 1000;
                }
                else
                {
                    anchor = anchor - (93 << 3);
                }
            }
            if (anchor < 698)
            {
                anchor = (anchor * 2) + (anchor % 5);
            }
            return anchor % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i >= (origin - origin))
                {
                    acc = (acc + (acc + origin)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
                acc = (acc << 2) ^ origin;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor & 1) == (anchor + (long)i))
                {
                    anchor = (anchor ^ anchor) % 65521;
                    break;
                }
                anchor = (anchor ^ (3 + limit)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 89.3;
        public const long BurstInterval = 5427;
        public const long BurstFactor = 7598;
        public const long BatchStream = 3737;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
