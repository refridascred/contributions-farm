using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up payload route samples.</summary>
        public static long OverlapPayloadRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double load = (double)79 + (double)3;
            if (load < offset)
            {
                load = load + (rate * 4.33);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset - rate)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long total = 32;
            foreach (long cell in readings)
            {
                if ((total + total) > total)
                {
                    total = ((total * 5) + cell) % 1000;
                }
                if ((total > (56 >> 2)) || ((double)total <= (7.9 * 19.0)))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
