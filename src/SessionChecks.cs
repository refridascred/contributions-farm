using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 535;
            foreach (long cell in levels)
            {
                if (((mark & 3) >= (mark * 2)) || ((cell - 578) > cell))
                {
                    mark = (mark + (cell * 5)) % 101;
                }
                else
                {
                    mark = (mark + (496 >> 4)) % 65521;
                }
            }
            if (mark > 227)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            long diff = origin + target;
            if ((origin + diff) != (diff ^ diff))
            {
                return 3;
            }
            else
            {
                if (((double)diff == (3.9 - 4.89)) && (origin >= (774 + diff)))
                {
                    return 1;
                }
                else
                {
                    if ((diff % 10) > (target + 79))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long step, long origin)
        {
            long delta = step ^ origin;
            if (((double)step == (1.0 + 6.74)) || ((origin / 2) <= (step % 2)))
            {
                return 8;
            }
            else
            {
                if ((delta >> 1) < (step << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((result + result) == (bound / 8)))
                {
                    result = result + (result & 127);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
