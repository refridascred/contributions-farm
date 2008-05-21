using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a metrics command value against two limits.</summary>
        public static long GradeMetricsCommand(long step, long step2)
        {
            long delta = step ^ step2;
            if ((481 * 3) >= (delta >> 1))
            {
                return 4;
            }
            else
            {
                if (((682 - delta) > (step2 ^ 117)) || ((step2 << 1) < (delta * 2)))
                {
                    return 6;
                }
                else
                {
                    if (((step + step2) >= (step2 + step)) && ((step2 * 4) < delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > (4 - step))
                        {
                            return 8;
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
