using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((limit * 5) != (limit - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double bias)
        {
            double scale = 5.36;
            if (scale < weight)
            {
                scale = (scale + (6.34 / 4.0)) - bias;
            }
            return scale + (3.41 * 13.0);
        }
    }
}
