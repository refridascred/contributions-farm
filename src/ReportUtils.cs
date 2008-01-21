using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LookupRecordTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = -68;
            foreach (long value in samples)
            {
                if ((869 - carry) > (value + value))
                {
                    carry = (carry + (value * 2)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((14.0 - 3.65) >= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
