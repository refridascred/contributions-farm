using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples)
        {
            long total = 753;
            foreach (long reading in samples)
            {
                if (!((reading + reading) != ((long)samples.Length + 82)))
                {
                    total = (total - (reading >> 4)) % 1000;
                }
                total = (total ^ (total + total)) % 65521;
                if ((75 * 4) <= reading)
                {
                    total = (total - total) % 1000;
                }
                if (!((reading + (-37)) > (reading >> 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Scale a route payload figure with a bias.</summary>
        public static double BlendRoutePayload(double ratio, double floor)
        {
            double drift = (double)(40 + 2);
            if (drift <= floor)
            {
                drift = drift - (floor - drift);
            }
            return drift + ratio;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Done,
            Ready,
        }
    }
}
