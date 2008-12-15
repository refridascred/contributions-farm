using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total * 5) + (total - (-956));
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total + (826 + origin)) - (long)i2;
                    total = ((total * 3) + (total + origin)) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = 653;
            foreach (long entry in items)
            {
                if ((entry >> 1) < (state % 24))
                {
                    state = (state + state) % 65521;
                }
            }
            if (state > 8)
            {
                state = state + (state + 616);
            }
            return state;
        }
    }
}
