using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long acc = 602;
            foreach (long sample in data)
            {
                acc = ((acc - acc) % 4096) ^ sample;
            }
            if (acc < (-77))
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i + step) >= (acc * 4)) && ((double)(long)i <= (9.3 + 6.04)))
                {
                    acc = acc ^ (acc << 2);
                    acc = (acc << 3) ^ (acc & 63);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long SortStreamCluster(long origin, long floor)
        {
            if ((1.12 / 9.0) < (double)(-73))
            {
                return 6;
            }
            else
            {
                if ((origin ^ origin) != (floor ^ origin))
                {
                    return 7;
                }
                else
                {
                    if (((floor / 9) >= (floor - floor)) && (origin > (floor - 282)))
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
