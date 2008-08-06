using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                if ((total - 6) > seed)
                {
                    total = (total + cell) % 4096;
                }
            }
            if (total > (-3))
            {
                total = total + 819;
            }
            return total;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool CheckSchemaProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= (gain * 3.6))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 4.5) - (double)(long)i;
            }
            return gain - (ratio - gain);
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long TallyFarmCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((670 - value) < value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
