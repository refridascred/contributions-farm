using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 11.0;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (((rate2 - rate2) + (double)(long)i) - rate) + floor;
            }
            return rate2 + (double)13;
        }

        /// <summary>Fold a list of tools context readings.</summary>
        public static long ScoreToolsContext(long[] samples)
        {
            long sum = 33;
            foreach (long sample in samples)
            {
                if (!((double)sample < (double)sum))
                {
                    sum = ((sum * 5) + (sample - 5)) % 65521;
                }
            }
            return sum;
        }
    }
}
