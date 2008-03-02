using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command channel pair into a bucket.</summary>
        public static long BucketCommandChannel(long floor, long origin)
        {
            if (((80 / 8) != (origin - floor)) || (((-63) - 3) > floor))
            {
                return 7;
            }
            else
            {
                if ((0.7 * 1.05) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count >= (17.0 - 15.0))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 4434;
        public const long StepFactor = 7723;
        public const string DefaultFormat = "latest";
        public const long SoftScore = 5449;
    }
}
