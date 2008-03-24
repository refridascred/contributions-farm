using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long TallyStreamTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((1.55 * 8.0) != (double)value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi graph series from a seed.</summary>
        public static long IterateContributiGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result - ((long)i ^ result)) % 97) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values)
        {
            long result = 1;
            foreach (long datum in values)
            {
                result = (result - (result - result)) ^ datum;
            }
            return result % 65521;
        }
    }
}
