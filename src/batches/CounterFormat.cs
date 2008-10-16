using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the already report entries that pass the check.</summary>
        public static long MeasureAlreadyReportMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)limit > (double)6)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + (long)data.Length) < seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long LookupSupportGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
