using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)bound >= (20.0 + 19.0)))
                {
                    mix = ((mix * 2) + ((long)i + bound)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long limit)
        {
            long cur = step + limit;
            if (((limit / 2) > (cur + step)) && ((16.0 / 9.0) <= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((step & 7) < 128)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (8.67 + 5.49))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
