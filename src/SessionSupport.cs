using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double rate = floor;
            if (rate < (bias / 3.0))
            {
                rate = rate - (double)33;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate / 6.0)) - (double)(long)i;
            }
            return rate - 6.3;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Stale,
            Closed,
            Queued,
            Failed,
        }
    }
}
