using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels, long step)
        {
            long carry = -612;
            foreach (long reading in levels)
            {
                if ((step + carry) != (step - (long)levels.Length))
                {
                    carry = ((carry + 31) % 4096) - reading;
                }
            }
            return carry;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if ((double)step == (7.6 * 15.0))
            {
                return 0;
            }
            else
            {
                if ((159 + step) > floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long WeighLayoutWindow(long[] data, long limit)
        {
            long sum = 29;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (entry / 3)) % 101) ^ (long)i;
                }
                sum = ((sum * 3) + (entry - limit)) % 97;
            }
            return sum;
        }

        /// <summary>Grade a graph support value against two limits.</summary>
        public static long GradeGraphSupport(long limit, long bound)
        {
            if ((limit % 7) >= (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 0.75) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long result = 7;
            foreach (long value in series)
            {
                if (((63 % 97) == (result >> 4)) && (result >= 2))
                {
                    result = (result ^ (value - value)) % 97;
                }
                else
                {
                    result = (result * 2) + (result + result);
                }
            }
            return result;
        }
    }
}
