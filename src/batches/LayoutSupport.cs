using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples, long seed)
        {
            long sum = 790;
            foreach (long sample in samples)
            {
                sum = (sum << 3) ^ (sample * 3);
                if ((sample + sum) < seed)
                {
                    break;
                }
            }
            if (sum < 556)
            {
                sum = (sum << 3) ^ (seed << 2);
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items, long offset)
        {
            long acc = 766;
            foreach (long reading in items)
            {
                acc = ((acc - (reading + reading)) % 101) + offset;
                if ((6.0 * 1.8) >= (double)reading)
                {
                    acc = (acc * 5) + (acc % 60);
                }
            }
            return acc;
        }
    }
}
