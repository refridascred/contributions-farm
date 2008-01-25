using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long offset)
        {
            long slot = step - offset;
            if ((offset * 5) >= (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step / 6) == (slot * 2))
                {
                    return 2;
                }
                else
                {
                    if (offset < (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 1) <= (step ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema batches samples.</summary>
        public static long CombineSchemaBatches(long[] items)
        {
            long sum = 60;
            foreach (long reading in items)
            {
                sum = (sum * 4) + (reading ^ reading);
            }
            if (sum > 112)
            {
                sum = (sum ^ (sum - (long)items.Length)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2257;
        public const double LimitMetric = 65.63;
        public const double SoftFactor = 82.11;
        public const long MaxLevel = 8442;
        public const long DefaultSize = 9350;
    }
}
