using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long delta = offset + seed;
            if ((delta + seed) == (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((seed - offset) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 5) <= offset)
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

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
