using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values, long step)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                if ((mark * 4) > (step ^ mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (step < sample)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (29 / 8)) % 4096;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5067;
        public const long BaseSize = 1343;
        public const long MaxBatches = 747;
        public const string BaseBatches = "stable-1";
    }
}
