using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((6.1 - 13.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)6 == (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 7213;
        public const double IdleBudget = 94.42;
        public const double MaxSize = 91.46;
    }
}
