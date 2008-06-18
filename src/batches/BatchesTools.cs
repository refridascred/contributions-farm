using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Synced,
            Locked,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 738;
            foreach (long value in items)
            {
                mark = (mark << 2) ^ (value & 127);
            }
            return mark;
        }
    }
}
