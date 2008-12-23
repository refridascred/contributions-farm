using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema batch value against two limits.</summary>
        public static long SortSchemaBatch(long step, long origin)
        {
            long step2 = step + origin;
            if ((step2 > (958 + step2)) && ((step2 - origin) > origin))
            {
                return 4;
            }
            else
            {
                if (!(12.0 < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (((7.0 / 8.0) != (double)step2) && ((double)origin != (double)step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long total = 63;
            foreach (long entry in series)
            {
                total = ((total * 3) + (entry * 2)) % 1000;
            }
            if (total < 178)
            {
                total = ((total << 3) ^ (59 % 64)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
