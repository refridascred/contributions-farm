using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((347 - 695) > (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (offset / 6.0))
            {
                mean = mean - offset;
            }
            return mean + (ratio / 6.0);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
