using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double scale = (weight - weight) + (weight * 4.62);
            if (scale < 2.51)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (6.0 + offset)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Closed,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((state * 2) <= (bound << 3)))
                {
                    state = (state - (state << 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
