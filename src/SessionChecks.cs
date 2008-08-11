using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = 6.36;
            if (ratio >= (span + 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (9.13 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (span / 3.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen >= (cell % 24)) || !(((-13) - cell) <= (seen - cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
