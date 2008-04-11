using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + 14;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long carry = 9;
            foreach (long datum in items)
            {
                if ((datum * 3) <= (carry + datum))
                {
                    carry = (carry + datum) - bound;
                }
            }
            return carry;
        }

        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long MeasureMetricAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ tally) != (tally + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Derive the next contributi order value from a seed.</summary>
        public static long RollContributiOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
