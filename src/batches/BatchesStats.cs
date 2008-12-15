using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Draft,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long RankFarmCommand(long step, long origin)
        {
            if ((step + 82) <= (step * 3))
            {
                return 2;
            }
            else
            {
                if ((7 >> 5) < step)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many profile batch samples are out of range.</summary>
        public static long TallyProfileBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(bound > (cell << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((651 + 70) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
