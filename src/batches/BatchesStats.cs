using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 2307;
        public const double MinScore = 85.19;
        public const long BaseRatio = 7897;
        public const double BatchDepth = 40.99;
        public const long StepPayload = 4473;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long origin)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                if ((-377) <= datum)
                {
                    acc = (acc ^ (origin % 97)) % 1000;
                }
            }
            if (acc > 23)
            {
                acc = (acc ^ (7 << 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 1) < count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
