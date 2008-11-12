using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long CountBufferLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) != (34 ^ 235))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            New,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
