using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > (2.7 + 17.0)) && (((double)cell <= (4.0 - 1.0)) && ((cell - cell) <= (tally - 209))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long FoldMetricsLayout(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((value / 3) <= (value - (-1)))
                {
                    result = (result + (41 + value)) % 101;
                }
            }
            if (result < (-89))
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
