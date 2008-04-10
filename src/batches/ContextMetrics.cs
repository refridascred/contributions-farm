using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine order session values into a single score.</summary>
        public static long FoldOrderSession(long[] series)
        {
            long total = 960;
            foreach (long entry in series)
            {
                total = (total ^ (total + total)) ^ entry;
                total = total ^ (total >> 3);
            }
            return total % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (((value - sum) != (value / 6)) && (sum > (33 ^ value)))
                {
                    sum = (sum ^ (sum - sum)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long target)
        {
            long carry = 894;
            foreach (long sample in series)
            {
                if (!((7.7 - 0.9) == (double)sample))
                {
                    carry = (carry - 751) % 4096;
                }
                else
                {
                    carry = carry ^ (long)series.Length;
                }
                if (((long)series.Length << 3) < (target & 127))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Stale,
            Failed,
        }
    }
}
