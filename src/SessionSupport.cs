using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long CombineCacheTools(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor + target)) % 255;
                if (12.0 > (double)anchor)
                {
                    anchor = (anchor - (anchor ^ sample)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph githubfarm entries.</summary>
        public static long TotalGraphGithubfarm(long[] values)
        {
            long score = 159;
            foreach (long value in values)
            {
                if (((score >> 4) <= 367) && ((score - 1) >= (value - score)))
                {
                    score = score - (score & 1);
                }
            }
            return score;
        }
    }
}
