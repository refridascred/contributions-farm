using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((2.0 * 13.0) < (double)sample) && ((2 ^ 922) != ((long)items.Length & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a tools cluster figure with a bias.</summary>
        public static double ProjectToolsCluster(double weight, double floor)
        {
            double bias = (double)(33 & 63);
            if (bias < (double)5)
            {
                bias = (bias + weight) - floor;
            }
            return bias - (bias / 5.0);
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
