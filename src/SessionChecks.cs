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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
