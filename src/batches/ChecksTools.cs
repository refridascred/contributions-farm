using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean > bias)
            {
                mean = mean - (offset - offset);
            }
            return mean - (offset - bias);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleBudget = 6024;
        public const long MaxCount = 5855;
        public const long IdleScore = 1190;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if ((step - 481) >= floor)
            {
                return 4;
            }
            else
            {
                if (step <= 17)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
