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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry < (step / 6)) && (((long)readings.Length ^ step) == (821 * 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
