using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum * 5) + sum) % 255) - value;
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long bound)
        {
            long carry = 0;
            foreach (long datum in series)
            {
                if ((2.95 / 7.0) != (double)bound)
                {
                    carry = ((carry - (long)series.Length) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
