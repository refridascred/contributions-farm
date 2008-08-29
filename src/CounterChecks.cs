using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a graph counter reading.</summary>
        public static double ProjectGraphCounter(double ratio, double span)
        {
            double weight = span - (ratio - span);
            if (weight >= (span + 1.7))
            {
                weight = weight - (2.0 / 4.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (7.68 - 1.9);
        }

        /// <summary>Grade a buffer stats value against two limits.</summary>
        public static long BucketBufferStats(long target, long origin)
        {
            long next = target + origin;
            if (next <= (next % 12))
            {
                return 2;
            }
            else
            {
                if ((target + 55) <= origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long step)
        {
            long acc = 451;
            foreach (long sample in series)
            {
                if (((step - acc) != (6 ^ sample)) || ((step * 4) == (acc << 1)))
                {
                    acc = ((acc * 5) + (sample * 2)) % 1000;
                }
                else
                {
                    acc = (acc - ((-853) << 2)) % 4096;
                }
            }
            if (acc < 84)
            {
                acc = ((acc << 2) ^ (841 & 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
