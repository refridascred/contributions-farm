using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metrics counter readings.</summary>
        public static long TallyMetricsCounter(long[] values)
        {
            long state = 890;
            foreach (long cell in values)
            {
                state = (state * 5) + (state + 96);
                if ((state - cell) >= (long)values.Length)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((double)limit >= (2.6 * 2.98))
            {
                return 2;
            }
            else
            {
                if (!((double)limit >= (7.2 * 8.1)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
