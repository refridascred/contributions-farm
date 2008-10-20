using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account filter entry that matches the target.</summary>
        public static long LocateAccountFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry + (carry + carry)) % 97) ^ entry;
            }
            return carry;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long TallyMetricProfileMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (5.07 < (double)value)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
