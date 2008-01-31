using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long AuditClusterSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) <= cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (hits % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
