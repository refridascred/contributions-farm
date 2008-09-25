using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((524 - item) > item)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series, long target)
        {
            long total = 18;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total + (long)i) % 255) - cell) - target;
                    total = (total + (long)i) % 65521;
                }
                total = total - (total * 3);
            }
            if (total > 2)
            {
                total = (total - total) % 4096;
            }
            return total;
        }
    }
}
