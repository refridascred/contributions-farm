using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - value) == (value % 16)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((7 - 362) != (seen + seen))
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally > (3.8 / 6.0)) || ((double)reading < (5.5 * 0.89)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
