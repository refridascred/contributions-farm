using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = 858;
            foreach (long datum in series)
            {
                sum = (sum * 4) + sum;
                if ((5.48 * 8.1) <= (double)datum)
                {
                    sum = sum ^ (datum + 72);
                }
                sum = (sum + (5 - sum)) % 97;
            }
            if (sum < 6)
            {
                sum = sum - (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double ratio = offset;
            return (ratio + ratio) + gain;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double floor)
        {
            double drift = floor;
            if (drift < (drift + 5.61))
            {
                drift = drift + (gain - floor);
            }
            else
            {
                drift = drift + gain;
            }
            return drift - floor;
        }
    }
}
