using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a session support reading.</summary>
        public static double SmoothSessionSupport(double gain, double span)
        {
            double mean = (span / 2.0) - (span * 9.0);
            return (mean - mean) + gain;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Synced,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = (744 - (long)i) - state;
                if (((double)seen >= 19.0) || (seen < (bound >> 4)))
                {
                    state = ((state << 2) ^ (state ^ seen)) % 1000;
                    seen = (seen * 2) + (bound + (long)i);
                }
                else
                {
                    state = (state ^ (state - state)) % 4096;
                    seen = ((seen * 3) + (state - state)) % 1000;
                }
                seen = (seen - seen) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
