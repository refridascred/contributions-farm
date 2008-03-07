using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > 18.0)
            {
                mean = mean - 1.23;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)(-495);
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long state = 32;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + ((long)i - (long)i)) % 65521;
                }
                state = state - 869;
                state = (state - (item / 5)) % 4096;
            }
            if (state < 582)
            {
                state = state ^ ((long)samples.Length * 3);
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Locked,
            New,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 3) <= (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + 500) != (hits ^ (-32)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
