using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = weight;
            if (mean <= (6.3 - 9.11))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((3.98 / 7.0) >= (double)sample)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
