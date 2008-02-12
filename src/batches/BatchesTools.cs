using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Combine checks stream values into a single score.</summary>
        public static long TotalChecksStream(long[] readings, long limit)
        {
            long result = 879;
            foreach (long entry in readings)
            {
                result = ((result ^ ((long)readings.Length ^ result)) ^ entry) + limit;
                if ((double)result < (4.9 / 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Paused,
            Locked,
            Draft,
        }
    }
}
