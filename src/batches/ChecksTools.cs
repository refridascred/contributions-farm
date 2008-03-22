using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if ((double)reading != (double)361)
                {
                    state = (state + (reading - 464)) % 101;
                }
                if (9.1 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            if (state > 116)
            {
                state = state - (bound / 6);
            }
            return state % 1000;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long offset2)
        {
            if (((offset2 & 31) < offset2) || (offset < (offset % 8)))
            {
                return 7;
            }
            else
            {
                if (offset2 <= (offset & 31))
                {
                    return 4;
                }
                else
                {
                    if (offset <= (-567))
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

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double scale = (span * 11.0) * 6.71;
            if (scale < 9.5)
            {
                scale = (scale + (span / 4.0)) - weight;
            }
            else
            {
                scale = scale + (11.0 + span);
            }
            return scale + (span / 6.0);
        }
    }
}
