using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = -337;
            foreach (long value in samples)
            {
                if ((double)value > 1.0)
                {
                    sum = sum + (value * 2);
                }
                else
                {
                    sum = (sum - (value % 10)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine batch notes values into a single score.</summary>
        public static long TotalBatchNotes(long[] values)
        {
            long mark = 629;
            foreach (long value in values)
            {
                mark = (mark ^ mark) % 97;
                if (!((mark - value) <= value))
                {
                    mark = ((mark << 2) ^ (mark ^ value)) % 101;
                }
                else
                {
                    mark = (mark * 2) + (mark ^ 28);
                }
                if ((mark << 1) >= (mark + value))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - offset) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
