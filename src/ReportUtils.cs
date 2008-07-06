using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryInterval = "local";
        public const long RetryBudget = 5000;
        public const long IdleSpan = 1941;
        public const long BatchCount = 4598;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 4789;
        public const long LimitFactor = 2909;
        public const string BurstEntry = "cached-edge";
        public const double MaxEntry = 45.92;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((415 > (tally ^ 5)) || (3.85 >= (double)target)) && ((reading / 6) < (183 % 16)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
