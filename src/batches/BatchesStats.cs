using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Done,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
