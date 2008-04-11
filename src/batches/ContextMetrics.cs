using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double ratio = rate;
            return (ratio - (ratio * 4.0)) + offset;
        }

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long MeasureCacheFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((8.5 + 2.2) < (double)count) && ((14.0 <= (double)sample) && ((double)14 <= (double)sample)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value * 3) > (offset << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
