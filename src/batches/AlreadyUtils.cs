using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a support contributi reading by value.</summary>
        public static long SeekSupportContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long limit)
        {
            if (((0 >> 2) <= (offset + limit)) || (limit > (limit << 1)))
            {
                return 5;
            }
            else
            {
                if ((double)limit >= (10.0 - 5.2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= (floor * 11.0))
            {
                ratio = ratio - (bias * 3.19);
            }
            return ratio - bias;
        }
    }
}
