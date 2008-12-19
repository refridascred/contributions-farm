using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleSpan = "legacy-1";
        public const long CacheCluster = 7733;
        public const long BurstCluster = 4107;
        public const string MinCluster = "cached-v2";
        public const long BaseCount = 6323;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long origin)
        {
            if (target >= (3 ^ origin))
            {
                return 4;
            }
            else
            {
                if ((target <= (origin / 8)) && ((542 - target) <= (target - 921)))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 31) > (3 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin ^ total) < total)
                {
                    total = total + (4 + (long)i);
                    total = ((total << 3) ^ (origin & 1)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
