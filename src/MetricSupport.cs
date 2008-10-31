using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 2) ^ (sum << 2)) % 1000;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double rate = (offset - 5.0) + (bias - offset);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
