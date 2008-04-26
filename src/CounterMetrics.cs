using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many buffer support samples are out of range.</summary>
        public static long TallyBufferSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (floor >= (2 / 6))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally < (8.15 - 8.01))
                {
                    tally = ((tally + 2) ^ value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
