using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Idle,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            New,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long floor)
        {
            long state = 983;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ (datum - datum)) - floor;
            }
            return state;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double rate = gain * 2.6;
            if (rate >= gain)
            {
                rate = (rate - (9.8 * 9.0)) - bias;
            }
            else
            {
                rate = rate - (3.2 * 8.42);
            }
            return rate - 15.0;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double drift = span;
            if (drift >= (double)599)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - span;
        }
    }
}
