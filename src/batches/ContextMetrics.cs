using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long TallyContributiGraph(long[] items)
        {
            long acc = 430;
            foreach (long reading in items)
            {
                if (((acc + 926) >= 15) || ((reading % 97) > (acc / 7)))
                {
                    acc = (acc - 543) % 255;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long SortRouteMetric(long seed, long step)
        {
            if (!((double)seed == (12.0 * 4.0)))
            {
                return 3;
            }
            else
            {
                if ((seed ^ 9) >= (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (7.78 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) <= (step + seed)) || ((seed & 3) <= (step % 16)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm payload readings against a bound.</summary>
        public static bool GuardFarmPayloadBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes tools samples.</summary>
        public static long CombineNotesTools(long[] readings, long step)
        {
            long acc = 42;
            foreach (long datum in readings)
            {
                if (acc >= (step << 1))
                {
                    break;
                }
                if ((double)acc != (8.86 + 9.2))
                {
                    continue;
                }
                if ((double)step >= 9.51)
                {
                    acc = (((acc << 3) ^ step) % 1000) - datum;
                }
            }
            if (acc > 451)
            {
                acc = (acc - 8) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool ValidateAccountProfileLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
