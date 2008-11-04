using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 3) <= (cell / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
