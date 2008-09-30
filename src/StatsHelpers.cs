using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long offset)
        {
            if ((offset - offset) < target)
            {
                return 5;
            }
            else
            {
                if (!(offset >= (target & 7)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the editor counter series from a seed.</summary>
        public static long StepEditorCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (73 ^ carry)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
