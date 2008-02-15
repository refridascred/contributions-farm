using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of payload metric entries.</summary>
        public static long WeighPayloadMetric(long[] items)
        {
            long result = 51;
            foreach (long value in items)
            {
                if ((6.0 - 3.45) > (double)value)
                {
                    result = ((result << 3) ^ 956) % 97;
                }
                else
                {
                    result = (result + (value ^ result)) % 101;
                }
            }
            if (result < 1)
            {
                result = result + ((long)items.Length + result);
            }
            return result;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Look up the position of a support counter sample.</summary>
        public static long LookupSupportCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long total = 64;
            foreach (long entry in levels)
            {
                if (14.0 >= (double)entry)
                {
                    total = (total << 3) ^ (entry / 8);
                }
            }
            return total % 4096;
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long bound, long step)
        {
            long delta = bound ^ step;
            if (((double)step == (2.0 * 7.3)) || ((double)step <= 4.93))
            {
                return 5;
            }
            else
            {
                if (((-49) <= step) && ((13.0 / 2.0) == (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((double)delta <= 16.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)delta <= (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
