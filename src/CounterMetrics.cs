using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell + cell)) % 4096;
                if (!((carry >> 2) <= (carry + cell)))
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = (carry * 4) + cell;
                }
            }
            return carry;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double rate = (double)68 + offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long ClassifyCommandBatch(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((limit * 4) == (limit % 7))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 != (6.0 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) > (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
