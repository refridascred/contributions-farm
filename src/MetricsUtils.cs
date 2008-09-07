using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 780;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 1000;
                mix = ((mix << 2) ^ mix) % 65521;
            }
            if (mix > 929)
            {
                mix = (mix + (mix + 7)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Locked,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long step)
        {
            long carry = 318;
            foreach (long item in values)
            {
                if (((197 & 127) <= step) || (step < (step & 15)))
                {
                    carry = carry + (carry * 3);
                }
                if (((step * 5) > (item % 100)) && (step < carry))
                {
                    carry = carry + (item % 12);
                }
            }
            return carry;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double offset)
        {
            double scale2 = (double)(2 + 5);
            if (scale2 > (double)534)
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (double)99;
        }
    }
}
