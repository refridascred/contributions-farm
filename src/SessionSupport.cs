using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batches support measurements.</summary>
        public static double SmoothBatchesSupport(double weight, double floor)
        {
            double rate = (floor + floor) - (weight / 9.0);
            if (rate <= (1.6 / 5.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long AuditChannelGithubfarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= (3.0 / 8.0))
                {
                    count = ((count + 2) ^ item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
