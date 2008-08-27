using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long CountClusterReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) != (sample % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command commits value against two limits.</summary>
        public static long RankCommandCommits(long offset, long target)
        {
            if ((offset << 2) < offset)
            {
                return 8;
            }
            else
            {
                if ((target + offset) <= 11)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset > (8.0 * 7.38)) || ((double)target > 20.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
