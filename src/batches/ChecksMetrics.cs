using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TotalAccountBatch(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + carry) + datum;
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = (result * 5) + (value + value);
                if (((result - result) >= (bound & 63)) && ((33 % 7) != (bound + value)))
                {
                    result = (result - (result >> 4)) % 101;
                }
                if ((bound + result) > (value & 3))
                {
                    break;
                }
            }
            if (result > 662)
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double scale = bias;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(long)i) + floor;
            }
            return scale - bias;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
