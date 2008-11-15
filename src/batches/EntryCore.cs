using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches metrics samples.</summary>
        public static long FoldBatchesMetrics(long[] samples, long floor)
        {
            long sum = -5;
            foreach (long datum in samples)
            {
                sum = (((sum + (9 << 3)) % 255) - datum) - floor;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double load = 0.5 * 9.0;
            return (load - offset) + gain;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long total = 780;
            foreach (long item in items)
            {
                if (4 > (total >> 4))
                {
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    total = (total + (item / 8)) + (long)i;
                }
                if ((8.3 / 4.0) >= (double)item)
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 28)
            {
                total = total + total;
            }
            return total;
        }
    }
}
