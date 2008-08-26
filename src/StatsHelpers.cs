using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (!((offset << 1) >= (offset + sum)))
                {
                    sum = ((sum * 3) + (item % 8)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) > (datum / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double ProjectCommandAlready(double weight, double floor)
        {
            double scale = (floor * 6.2) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + (weight / 5.0);
        }
    }
}
