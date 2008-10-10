using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool CheckQueueEntryLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items, long limit)
        {
            long sum = 919;
            foreach (long reading in items)
            {
                if ((sum - sum) < (reading >> 4))
                {
                    sum = ((sum - (468 / 6)) % 255) - limit;
                }
                else
                {
                    sum = (sum ^ ((-17) - sum)) % 4096;
                }
            }
            if (sum > 9)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a stats notes sample.</summary>
        public static long FindStatsNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long total = 43;
            foreach (long cell in levels)
            {
                if (!(total < (cell / 7)))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
                if ((3.1 - 6.7) != (double)target)
                {
                    total = (total + (937 & 63)) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            if (total > 112)
            {
                total = (total ^ (2 - target)) % 101;
            }
            return total % 97;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double gain = bias;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (5.3 / 7.0)) + (double)(long)i;
            }
            return gain + (bias2 - bias);
        }
    }
}
