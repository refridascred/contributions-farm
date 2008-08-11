using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchSpan = 45.4;
        public const long RetryProfile = 6045;
        public const string LimitProfile = "strict-v2";

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long offset)
        {
            if ((double)26 > (double)floor)
            {
                return 1;
            }
            else
            {
                if (floor < (offset / 4))
                {
                    return 4;
                }
                else
                {
                    if (offset > (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long TallyEntryMetricsMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(matches < (9 * 5)))
                {
                    matches = ((matches + 2) ^ entry) - seed;
                }
            }
            return matches;
        }
    }
}
