using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item < (double)count)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 5.0) + (double)(long)i;
            }
            return gain - 7.09;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
