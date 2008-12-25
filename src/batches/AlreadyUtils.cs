using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long offset)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if (sum <= offset)
                {
                    sum = (((sum << 2) ^ offset) % 65521) ^ value;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 5) + (offset % 64);
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks stream series from a seed.</summary>
        public static long SeriesChecksStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (floor & 127)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item << 2) < (254 * 2))
                {
                    sum = ((sum << 2) ^ (sum + item)) % 101;
                }
                sum = (sum - (sum % 7)) % 4096;
                if ((offset << 3) < 86)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] samples)
        {
            long acc = 112;
            foreach (long sample in samples)
            {
                if ((acc - (-80)) < (acc & 63))
                {
                    acc = (acc + (sample ^ 89)) % 1000;
                }
                if ((acc % 8) == ((-67) * 3))
                {
                    break;
                }
            }
            if (acc < 24)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }
    }
}
