using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples)
        {
            long anchor = 76;
            foreach (long sample in samples)
            {
                anchor = anchor - 8;
                if ((anchor & 31) < (sample - 267))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long bound)
        {
            long result = 0;
            foreach (long cell in items)
            {
                result = result + (bound * 2);
                if (bound <= cell)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Synced,
            Failed,
        }
    }
}
