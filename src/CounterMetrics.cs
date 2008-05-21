using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long floor, long seed)
        {
            if ((floor + floor) < 770)
            {
                return 3;
            }
            else
            {
                if ((double)seed < (19.0 + 0.9))
                {
                    return 5;
                }
                else
                {
                    if (seed < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed * 4) >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Locked,
            Paused,
            Retry,
            New,
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long WeighFormatAccount(long[] levels, long seed)
        {
            long carry = -770;
            foreach (long entry in levels)
            {
                carry = (carry - seed) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] items, long seed)
        {
            long mix = 92;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ (value ^ 707)) - seed;
            }
            return mix;
        }
    }
}
