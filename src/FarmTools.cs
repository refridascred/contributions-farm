using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((18.0 > (double)bound) && ((5 > reading) && (bound < (reading + bound))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command format samples.</summary>
        public static long FoldCommandFormat(long[] values, long target)
        {
            long acc = 38;
            foreach (long sample in values)
            {
                acc = (((acc - (acc % 10)) % 65521) ^ sample) - target;
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }
    }
}
