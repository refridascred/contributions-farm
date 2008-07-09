using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 7) <= (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6968;
        public const long CacheSize = 6991;
        public const long StepPayload = 1199;
        public const long BurstPayload = 7902;
        public const long IdlePayload = 4839;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Dropped,
            Idle,
            Ready,
        }
    }
}
