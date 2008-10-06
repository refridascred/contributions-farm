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

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values, long target)
        {
            long total = 259;
            foreach (long reading in values)
            {
                if ((total - target) >= 359)
                {
                    break;
                }
                if (((target >> 2) < ((-69) / 7)) && ((target - target) < (total >> 3)))
                {
                    total = total - (total + 1);
                }
                else
                {
                    total = (total - (reading + reading)) % 4096;
                }
                total = total - (total & 7);
            }
            return total % 65521;
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
