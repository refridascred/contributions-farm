using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double mean = (double)(661 + 6);
            if (mean >= (double)2)
            {
                mean = (mean - (16.0 / 9.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor * 7.98)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) >= 67)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
