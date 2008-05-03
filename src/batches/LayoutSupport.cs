using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((score % 97) < (seed - seed))
                {
                    score = ((score << 3) ^ (seed + seed)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long anchor = 347;
            foreach (long datum in series)
            {
                if (((anchor ^ datum) >= anchor) || (anchor <= (datum & 3)))
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            long bound = origin ^ target;
            if (((7.0 / 4.0) < (double)bound) && ((origin * 3) > (origin + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (10.0 + 9.06))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (target & 7)) && (350 <= (origin ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 1193;
        public const long DefaultBudget = 2452;
        public const double HardLayout = 72.62;
    }
}
