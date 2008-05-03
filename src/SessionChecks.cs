using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            return mean - (rate + mean);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings)
        {
            long total = -61;
            foreach (long sample in readings)
            {
                total = (total - (264 - sample)) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long mix = 625;
            foreach (long value in levels)
            {
                if ((double)mix == (double)618)
                {
                    mix = ((mix * 5) + (value * 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
