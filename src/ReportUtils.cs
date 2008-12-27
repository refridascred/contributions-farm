using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2833;
        public const long SoftScore = 3211;
        public const string MaxContext = "open-1";

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session stats entries that pass the check.</summary>
        public static long AuditSessionStatsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally != (2.32 - 3.85))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (weight * 17.0)) + (double)(long)i) + bias;
            }
            return weight - (weight + weight);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseLevel = "primary-1";
        public const long MaxTimeout = 6861;
        public const long WindowFactor = 951;
        public const long MaxStream = 7703;
        public const long LimitStream = 3313;
    }
}
