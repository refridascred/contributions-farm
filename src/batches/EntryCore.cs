using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total ^ 1)) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long FindMetricsWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm buffer entries that pass the check.</summary>
        public static long CountGithubfarmBufferMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((cell - count) >= 421))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine report contributi values into a single score.</summary>
        public static long TotalReportContributi(long[] values)
        {
            long state = 295;
            foreach (long item in values)
            {
                state = (state + (item * 2)) % 97;
            }
            if (state > 7)
            {
                state = state ^ (975 + state);
            }
            return state % 4096;
        }
    }
}
