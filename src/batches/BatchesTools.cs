using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long bound)
        {
            if ((limit % 5) <= bound)
            {
                return 7;
            }
            else
            {
                if (limit > (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Queued,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark * 2) + (4 / 2);
                if ((0 * 4) <= ((long)i ^ mark))
                {
                    break;
                }
                else
                {
                    mark = mark ^ (mark << 3);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
