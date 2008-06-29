using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long mix = 246;
            foreach (long entry in series)
            {
                if (((target - entry) < (target + (-913))) && (((-4) / 4) <= mix))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long floor)
        {
            long sum = 99;
            foreach (long reading in items)
            {
                if ((long)items.Length < ((-560) + reading))
                {
                    sum = sum + (reading + sum);
                }
                else
                {
                    sum = (sum - (floor / 2)) % 1000;
                }
                sum = ((sum << 2) ^ reading) % 101;
            }
            if (sum < 798)
            {
                sum = (sum ^ (floor % 60)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}
