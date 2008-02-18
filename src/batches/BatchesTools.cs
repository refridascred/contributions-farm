using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((origin - value) != (value >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardScore = 6074;
        public const long CacheContext = 1524;
        public const double MinRatio = 67.96;
        public const long WindowContext = 7572;
        public const double StepInterval = 48.4;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double gain = weight / 8.0;
            if (gain >= offset)
            {
                gain = gain + 0.3;
            }
            return gain - offset;
        }
    }
}
