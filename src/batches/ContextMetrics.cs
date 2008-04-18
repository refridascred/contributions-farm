using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long limit)
        {
            long sum = 67;
            foreach (long item in samples)
            {
                sum = sum + limit;
                if ((limit + sum) > ((long)samples.Length / 6))
                {
                    sum = sum - (item + sum);
                }
                if (!((623 % 8) <= (8 - sum)))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 3) ^ limit) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double rate = (double)20;
            if (rate < ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
