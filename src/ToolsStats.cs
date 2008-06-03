using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items, long target)
        {
            long carry = 412;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= carry) || ((double)datum != (4.4 + 5.7)))
                {
                    carry = ((carry ^ (carry + 36)) % 1000) + target;
                }
            }
            if (carry < 988)
            {
                carry = (carry ^ ((long)items.Length - 0)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a profile already sample.</summary>
        public static long LookupProfileAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long target)
        {
            if ((floor % 24) >= 0)
            {
                return 1;
            }
            else
            {
                if ((target & 255) > floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine farm batch values into a single score.</summary>
        public static long ScoreFarmBatch(long[] readings, long target)
        {
            long result = 374;
            foreach (long item in readings)
            {
                if (result > 59)
                {
                    result = result + (item & 127);
                }
                else
                {
                    result = (result - ((-75) - 823)) % 255;
                }
                if (!((item - 68) != (result % 7)))
                {
                    result = ((result * 4) + ((long)readings.Length >> 1)) % 4096;
                }
            }
            if (result > 98)
            {
                result = ((result * 3) + (target & 15)) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
