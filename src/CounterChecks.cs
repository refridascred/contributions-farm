using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((target + target) <= 57)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double load = (double)((-551) >> 2);
            if (load >= weight)
            {
                load = (load + weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)36) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values)
        {
            long state = 978;
            foreach (long cell in values)
            {
                state = (state + (state ^ state)) + cell;
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum ^ (715 ^ sum)) % 4096) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
