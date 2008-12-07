using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if ((3.3 * 1.7) < (double)score)
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score + (value + value);
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first report filter entry that matches the target.</summary>
        public static long LookupReportFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 632;
        public const double SoftTools = 0.86;
        public const long BaseTools = 742;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
