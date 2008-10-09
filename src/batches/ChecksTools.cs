using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items, long seed)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                if (!((double)seed > 10.0))
                {
                    mark = (mark * 3) + seed;
                }
                else
                {
                    mark = ((mark * 2) + (seed % 5)) % 101;
                }
                if ((seed % 7) > (cell * 3))
                {
                    break;
                }
            }
            if (mark < 329)
            {
                mark = (mark - (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            if ((2 < step) && ((double)step >= (5.92 - 1.4)))
            {
                return 4;
            }
            else
            {
                if ((step - seed) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((768 ^ seed) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
